namespace ExpenseTracker
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newtoolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbSave = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblReadyCount = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            pnlFilter = new Panel();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            cbDateRange = new CheckBox();
            tbSearch = new TextBox();
            lblSearch = new Label();
            cbFilterCategory = new ComboBox();
            lblCategory = new Label();
            pnlSummary = new Panel();
            lblRemaining = new Label();
            numericUpDown1 = new NumericUpDown();
            lblBudget = new Label();
            lblSummary = new Label();
            dgvExpenses = new DataGridView();
            tmrClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, expenseToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newtoolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newtoolStripMenuItem
            // 
            newtoolStripMenuItem.Name = "newtoolStripMenuItem";
            newtoolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newtoolStripMenuItem.Size = new Size(223, 34);
            newtoolStripMenuItem.Text = "&New";
            newtoolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(223, 34);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(223, 34);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(223, 34);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Size = new Size(92, 29);
            expenseToolStripMenuItem.Text = "&Expense";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(164, 34);
            addToolStripMenuItem.Text = "&Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(164, 34);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(164, 34);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(270, 34);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete, toolStripSeparator1, tsbSave });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(878, 34);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(50, 29);
            tsbAdd.Text = "Add";
            tsbAdd.Click += addToolStripMenuItem_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(46, 29);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += editToolStripMenuItem_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(66, 29);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(53, 29);
            tsbSave.Text = "Save";
            tsbSave.Click += saveToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblReadyCount, lblClock });
            statusStrip1.Location = new Point(0, 569);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(878, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(704, 25);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReadyCount
            // 
            lblReadyCount.Name = "lblReadyCount";
            lblReadyCount.Size = new Size(86, 25);
            lblReadyCount.Text = "0 records";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(73, 25);
            lblClock.Text = "(clear it)";
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(cbDateRange);
            pnlFilter.Controls.Add(tbSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(cbFilterCategory);
            pnlFilter.Controls.Add(lblCategory);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 67);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(878, 92);
            pnlFilter.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(350, 49);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(152, 31);
            dtpTo.TabIndex = 7;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(315, 53);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(29, 25);
            lblTo.TabIndex = 6;
            lblTo.Text = "to";
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(147, 49);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(162, 31);
            dtpFrom.TabIndex = 5;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // cbDateRange
            // 
            cbDateRange.AutoSize = true;
            cbDateRange.Location = new Point(12, 49);
            cbDateRange.Name = "cbDateRange";
            cbDateRange.Size = new Size(129, 29);
            cbDateRange.TabIndex = 4;
            cbDateRange.Text = "Date range:";
            cbDateRange.UseVisualStyleBackColor = true;
            cbDateRange.CheckedChanged += cbDateRange_CheckedChanged;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(383, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(150, 31);
            tbSearch.TabIndex = 3;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(309, 13);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search:";
            // 
            // cbFilterCategory
            // 
            cbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterCategory.FormattingEnabled = true;
            cbFilterCategory.Items.AddRange(new object[] { "All", "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cbFilterCategory.Location = new Point(106, 10);
            cbFilterCategory.Name = "cbFilterCategory";
            cbFilterCategory.Size = new Size(182, 33);
            cbFilterCategory.TabIndex = 1;
            cbFilterCategory.SelectedIndexChanged += cbFilterCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 10);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 25);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // pnlSummary
            // 
            pnlSummary.Controls.Add(lblRemaining);
            pnlSummary.Controls.Add(numericUpDown1);
            pnlSummary.Controls.Add(lblBudget);
            pnlSummary.Controls.Add(lblSummary);
            pnlSummary.Dock = DockStyle.Bottom;
            pnlSummary.Location = new Point(0, 439);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(878, 130);
            pnlSummary.TabIndex = 4;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemaining.ForeColor = Color.Red;
            lblRemaining.Location = new Point(368, 77);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(286, 25);
            lblRemaining.TabIndex = 3;
            lblRemaining.Text = "Remaining this month: PHP 0.00";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Location = new Point(164, 71);
            numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown1.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(12, 73);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(145, 25);
            lblBudget.TabIndex = 1;
            lblBudget.Text = "Monthly budget:";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(12, 10);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(222, 25);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Shown: 0 Total: PHP 0.00";
            lblSummary.Click += lblSummary_Click;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 159);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.RowHeadersWidth = 62;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(878, 280);
            dgvExpenses.TabIndex = 5;
            dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
            dgvExpenses.DataBindingComplete += dgvExpenses_DataBindingComplete;
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 601);
            Controls.Add(dgvExpenses);
            Controls.Add(pnlSummary);
            Controls.Add(pnlFilter);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newtoolStripMenuItem;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblReadyCount;
        private ToolStripStatusLabel lblClock;
        private Panel pnlFilter;
        private Label lblCategory;
        private CheckBox cbDateRange;
        private TextBox tbSearch;
        private Label lblSearch;
        private ComboBox cbFilterCategory;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpFrom;
        private Panel pnlSummary;
        private Label lblBudget;
        private Label lblSummary;
        private NumericUpDown numericUpDown1;
        private Label lblRemaining;
        private DataGridView dgvExpenses;
        private System.Windows.Forms.Timer tmrClock;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSave;
    }
}
