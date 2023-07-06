namespace eAgenda.WinForms.ExpenseModule
{
    partial class ExpenseScreenForm
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
            txtDate = new DateTimePicker();
            label1 = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtId = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            cmbPay = new ComboBox();
            listItemsCategories = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Format = DateTimePickerFormat.Short;
            txtDate.Location = new Point(204, 108);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(231, 32);
            txtDate.TabIndex = 25;
            txtDate.Value = new DateTime(2023, 6, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(250, 250, 250);
            label1.Location = new Point(131, 113);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 24;
            label1.Text = "Date :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(250, 250, 250);
            txtDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.FromArgb(15, 15, 15);
            txtDescription.Location = new Point(204, 46);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(587, 32);
            txtDescription.TabIndex = 23;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.FromArgb(250, 250, 250);
            lblDescription.Location = new Point(73, 46);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(124, 30);
            lblDescription.TabIndex = 22;
            lblDescription.Text = "Description :";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(45, 45, 45);
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(250, 250, 250);
            txtId.Location = new Point(203, 304);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(230, 32);
            txtId.TabIndex = 21;
            txtId.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(250, 250, 250);
            label6.Location = new Point(155, 306);
            label6.Name = "label6";
            label6.Size = new Size(41, 30);
            label6.TabIndex = 20;
            label6.Text = "Id :";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(250, 250, 250);
            txtPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.FromArgb(15, 15, 15);
            txtPrice.Location = new Point(203, 239);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(230, 32);
            txtPrice.TabIndex = 27;
            txtPrice.Text = "R$ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(250, 250, 250);
            label2.Location = new Point(129, 230);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 26;
            label2.Text = "Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(250, 250, 250);
            label3.Location = new Point(25, 171);
            label3.Name = "label3";
            label3.Size = new Size(172, 30);
            label3.TabIndex = 28;
            label3.Text = "Payment Method:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(698, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 47);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(250, 250, 250);
            btnRegister.DialogResult = DialogResult.OK;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.FromArgb(15, 15, 15);
            btnRegister.Location = new Point(591, 369);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 30;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cmbPay
            // 
            cmbPay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPay.FormattingEnabled = true;
            cmbPay.Location = new Point(204, 173);
            cmbPay.Name = "cmbPay";
            cmbPay.Size = new Size(230, 33);
            cmbPay.TabIndex = 32;
            // 
            // listItemsCategories
            // 
            listItemsCategories.CheckOnClick = true;
            listItemsCategories.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listItemsCategories.FormattingEnabled = true;
            listItemsCategories.Location = new Point(6, 37);
            listItemsCategories.Margin = new Padding(4, 5, 4, 5);
            listItemsCategories.Name = "listItemsCategories";
            listItemsCategories.Size = new Size(305, 193);
            listItemsCategories.TabIndex = 35;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listItemsCategories);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(473, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 238);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categories :";
            // 
            // ExpenseScreenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(849, 453);
            Controls.Add(groupBox1);
            Controls.Add(cmbPay);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtDate);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtId);
            Controls.Add(label6);
            Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(250, 250, 250);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ExpenseScreenForm";
            Text = "ExpenseScreenForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker txtDate;
        private Label label1;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtId;
        private Label label6;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private Button btnRegister;
        private ComboBox cmbPay;
        private CheckedListBox listItemsCategories;
        private GroupBox groupBox1;
    }
}