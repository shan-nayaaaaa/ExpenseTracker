using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing;

namespace ExpenseTracker
{
    public partial class frmMain : Form
    {
        private List<Expense> expenses = new List<Expense>();
        private string? currentFile = null;
        private bool isDirty = false;

        public frmMain()
        {
            InitializeComponent();
        }

        // ---------- Startup ----------
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbFilterCategory.SelectedIndex = 0;   // "All"
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            ApplyFilter();
            UpdateTitle();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // ---------- Filtering and display ----------
        private void ApplyFilter()
        {
            IEnumerable<Expense> query = expenses;

            if (cbFilterCategory.Text != "All")
                query = query.Where(x => x.Category == cbFilterCategory.Text);

            string keyword = tbSearch.Text.Trim();
            if (keyword != "")
                query = query.Where(x => x.Description.Contains(keyword,
                                         StringComparison.OrdinalIgnoreCase));

            if (cbDateRange.Checked)
            {
                DateTime from = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;
                query = query.Where(x => x.Date.Date >= from && x.Date.Date <= to);
            }

            List<Expense> shown = query.OrderByDescending(x => x.Date)
                                       .ThenByDescending(x => x.Id)
                                       .ToList();
            dgvExpenses.DataSource = shown;

            lblSummary.Text = $"Shown: {shown.Count}   Total: PHP {shown.Sum(x => x.Amount):N2}";
            lblReadyCount.Text = $"{expenses.Count} records";
            UpdateBudget();
        }

        private void dgvExpenses_DataBindingComplete(object sender,
            DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvExpenses.Columns.Count == 0) return;

            dgvExpenses.Columns["Id"]!.Visible = false;
            dgvExpenses.Columns["Notes"]!.Visible = false;

            dgvExpenses.Columns["Date"]!.DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Format = "N2";
            dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }

        private void UpdateBudget()
        {
            decimal spent = expenses
                .Where(x => x.Date.Year == DateTime.Today.Year &&
                            x.Date.Month == DateTime.Today.Month)
                .Sum(x => x.Amount);

            decimal remaining = numericUpDown1.Value - spent;
            lblRemaining.Text = $"Remaining this month: PHP {remaining:N2}";
            lblRemaining.ForeColor = remaining < 0 ? Color.Red : Color.Green;
        }

        private void cbFilterCategory_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        private void tbSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void dtpFrom_ValueChanged(object sender, EventArgs e) => ApplyFilter();
        private void dtpTo_ValueChanged(object sender, EventArgs e) => ApplyFilter();
        private void nudBudget_ValueChanged(object sender, EventArgs e) => UpdateBudget();

        private void cbDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = cbDateRange.Checked;
            dtpTo.Enabled = cbDateRange.Checked;
            ApplyFilter();
        }

        // ---------- Dirty flag and title ----------
        private void SetDirty(bool value)
        {
            isDirty = value;
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string name = currentFile == null ? "Untitled" : Path.GetFileName(currentFile);
            this.Text = $"Expense Tracker - {name}{(isDirty ? "*" : "")}";
        }

        // ---------- Add / Edit / Delete ----------
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmExpense form = new frmExpense())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Expense newExpense = form.GetExpense();
                    newExpense.Id = expenses.Count == 0 ? 1 : expenses.Max(x => x.Id) + 1;
                    expenses.Add(newExpense);
                    SetDirty(true);
                    ApplyFilter();
                    lblStatus.Text = "Expense added.";
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow?.DataBoundItem is not Expense selected)
            {
                MessageBox.Show("Select an expense to edit.");
                return;
            }
            using (frmExpense form = new frmExpense(selected))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    SetDirty(true);
                    ApplyFilter();
                    lblStatus.Text = "Expense updated.";
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow?.DataBoundItem is not Expense selected)
            {
                MessageBox.Show("Select an expense to delete.");
                return;
            }
            DialogResult answer = MessageBox.Show(
                $"Delete \"{selected.Description}\" (PHP {selected.Amount:N2})?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                expenses.Remove(selected);
                SetDirty(true);
                ApplyFilter();
                lblStatus.Text = "Expense deleted.";
            }
        }

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) editToolStripMenuItem_Click(sender, e);
        }

        // ---------- Save / Open / New ----------
        private bool SaveFile()
        {
            string? path = currentFile;

            if (path == null)
            {
                using SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                dialog.FileName = "expenses.json";
                if (dialog.ShowDialog(this) != DialogResult.OK) return false;
                path = dialog.FileName;
            }

            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(path, JsonSerializer.Serialize(expenses, options));
                currentFile = path;
                SetDirty(false);
                lblStatus.Text = "File saved.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ConfirmUnsavedChanges()
        {
            if (!isDirty) return true;

            DialogResult answer = MessageBox.Show(
                "You have unsaved changes. Save them first?", "Unsaved Changes",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.Cancel) return false;
            if (answer == DialogResult.Yes) return SaveFile();
            return true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmUnsavedChanges()) return;
            expenses.Clear();
            currentFile = null;
            SetDirty(false);
            ApplyFilter();
            lblStatus.Text = "New file.";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmUnsavedChanges()) return;

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);
                expenses = loaded ?? new List<Expense>();
                currentFile = dialog.FileName;
                SetDirty(false);
                ApplyFilter();
                lblStatus.Text = "File opened.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmUnsavedChanges()) e.Cancel = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Expense Tracker v1.0\nDeveloper: Your Name",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblSummary_Click(object sender, EventArgs e)
        {

        }
    }
}