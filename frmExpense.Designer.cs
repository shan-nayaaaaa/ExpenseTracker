namespace ExpenseTracker
{
    partial class frmExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dtpDate = new DateTimePicker();
            tbDescription = new TextBox();
            cbCategory = new ComboBox();
            nudAmount = new NumericUpDown();
            gbPayment = new GroupBox();
            rbCard = new RadioButton();
            rbGcash = new RadioButton();
            rbCash = new RadioButton();
            cbRecurring = new CheckBox();
            tbNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            gbPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(128, 32);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(218, 31);
            dtpDate.TabIndex = 0;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(128, 69);
            tbDescription.MaxLength = 50;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(300, 31);
            tbDescription.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.DisplayMember = "Food";
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cbCategory.Location = new Point(128, 106);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(218, 33);
            cbCategory.TabIndex = 2;
            // 
            // nudAmount
            // 
            nudAmount.DecimalPlaces = 2;
            nudAmount.Location = new Point(128, 145);
            nudAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(158, 31);
            nudAmount.TabIndex = 3;
            nudAmount.ThousandsSeparator = true;
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(rbCard);
            gbPayment.Controls.Add(rbGcash);
            gbPayment.Controls.Add(rbCash);
            gbPayment.Location = new Point(12, 198);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(556, 87);
            gbPayment.TabIndex = 4;
            gbPayment.TabStop = false;
            gbPayment.Text = "Payment";
            // 
            // rbCard
            // 
            rbCard.AutoSize = true;
            rbCard.Location = new Point(347, 43);
            rbCard.Name = "rbCard";
            rbCard.Size = new Size(74, 29);
            rbCard.TabIndex = 2;
            rbCard.TabStop = true;
            rbCard.Text = "Card";
            rbCard.UseVisualStyleBackColor = true;
            // 
            // rbGcash
            // 
            rbGcash.AutoSize = true;
            rbGcash.Location = new Point(187, 43);
            rbGcash.Name = "rbGcash";
            rbGcash.Size = new Size(87, 29);
            rbGcash.TabIndex = 1;
            rbGcash.TabStop = true;
            rbGcash.Text = "GCash";
            rbGcash.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Location = new Point(27, 43);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(75, 29);
            rbCash.TabIndex = 0;
            rbCash.TabStop = true;
            rbCash.Text = "Cash";
            rbCash.UseVisualStyleBackColor = true;
            // 
            // cbRecurring
            // 
            cbRecurring.AutoSize = true;
            cbRecurring.Location = new Point(12, 291);
            cbRecurring.Name = "cbRecurring";
            cbRecurring.Size = new Size(183, 29);
            cbRecurring.TabIndex = 5;
            cbRecurring.Text = "Recurring monthly";
            cbRecurring.UseVisualStyleBackColor = true;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(128, 338);
            tbNotes.Multiline = true;
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(440, 98);
            tbNotes.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(338, 455);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(456, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 9;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 11;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 147);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 12;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 341);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 13;
            label5.Text = "Notes:";
            // 
            // frmExpense
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(587, 498);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbNotes);
            Controls.Add(cbRecurring);
            Controls.Add(gbPayment);
            Controls.Add(nudAmount);
            Controls.Add(cbCategory);
            Controls.Add(tbDescription);
            Controls.Add(dtpDate);
            Name = "frmExpense";
            Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private TextBox tbDescription;
        private ComboBox cbCategory;
        private NumericUpDown nudAmount;
        private GroupBox gbPayment;
        private RadioButton rbCard;
        private RadioButton rbGcash;
        private RadioButton rbCash;
        private CheckBox cbRecurring;
        private TextBox tbNotes;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider2;
    }
}