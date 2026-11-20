using System;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class frmExpense : Form
    {
        private readonly Expense expense;

        // existing == null  -> Add mode, otherwise Edit mode
        public frmExpense(Expense? existing = null)
        {
            InitializeComponent();

            dtpDate.MaxDate = DateTime.Today;
            cbCategory.Items.AddRange(new string[]
            {
                "Food", "Transportation", "Bills", "School", "Entertainment", "Others"
            });

            if (existing == null)
            {
                expense = new Expense();
                this.Text = "Add Expense";
                cbCategory.SelectedIndex = 0;
                rbCash.Checked = true;
            }
            else
            {
                expense = existing;
                this.Text = "Edit Expense";

                dtpDate.Value = existing.Date > DateTime.Today ? DateTime.Today : existing.Date;
                tbDescription.Text = existing.Description;
                cbCategory.SelectedItem = existing.Category;
                nudAmount.Value = existing.Amount;
                rbGcash.Checked = existing.PaymentMethod == "GCash";
                rbCard.Checked = existing.PaymentMethod == "Card";
                rbCash.Checked = !rbGcash.Checked && !rbCard.Checked;
                cbRecurring.Checked = existing.IsRecurring;
                tbNotes.Text = existing.Notes;
            }
        }

        public Expense GetExpense() => expense;

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                errorProvider1.SetError(tbDescription, "Description is required.");
                isValid = false;
            }
            if (cbCategory.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbCategory, "Choose a category.");
                isValid = false;
            }
            if (nudAmount.Value <= 0)
            {
                errorProvider1.SetError(nudAmount, "Amount must be greater than 0.");
                isValid = false;
            }
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            expense.Date = dtpDate.Value.Date;
            expense.Description = tbDescription.Text.Trim();
            expense.Category = cbCategory.Text;
            expense.Amount = nudAmount.Value;
            expense.PaymentMethod = rbGcash.Checked ? "GCash"
                                  : rbCard.Checked ? "Card" : "Cash";
            expense.IsRecurring = cbRecurring.Checked;
            expense.Notes = tbNotes.Text.Trim();

            this.DialogResult = DialogResult.OK;
        }
    }
}