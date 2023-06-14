namespace eAgenda.WinForms.ContactModule
{
    partial class ContactScreenForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPosition = new TextBox();
            txtCompany = new TextBox();
            txtId = new TextBox();
            txtPhone = new MaskedTextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(250, 250, 250);
            label1.Location = new Point(37, 65);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 3;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(250, 250, 250);
            label2.Location = new Point(43, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 4;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(250, 250, 250);
            label3.Location = new Point(353, 125);
            label3.Name = "label3";
            label3.Size = new Size(81, 30);
            label3.TabIndex = 5;
            label3.Text = "Phone :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(250, 250, 250);
            label4.Location = new Point(20, 183);
            label4.Name = "label4";
            label4.Size = new Size(95, 30);
            label4.TabIndex = 6;
            label4.Text = "Position :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(250, 250, 250);
            label5.Location = new Point(324, 183);
            label5.Name = "label5";
            label5.Size = new Size(110, 30);
            label5.TabIndex = 7;
            label5.Text = "Company :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(250, 250, 250);
            label6.Location = new Point(75, 233);
            label6.Name = "label6";
            label6.Size = new Size(41, 30);
            label6.TabIndex = 8;
            label6.Text = "Id :";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(250, 250, 250);
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(15, 15, 15);
            txtName.Location = new Point(123, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(519, 30);
            txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(250, 250, 250);
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(15, 15, 15);
            txtEmail.Location = new Point(123, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 30);
            txtEmail.TabIndex = 10;
            // 
            // txtPosition
            // 
            txtPosition.BackColor = Color.FromArgb(250, 250, 250);
            txtPosition.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPosition.ForeColor = Color.FromArgb(15, 15, 15);
            txtPosition.Location = new Point(123, 183);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(195, 30);
            txtPosition.TabIndex = 11;
            // 
            // txtCompany
            // 
            txtCompany.BackColor = Color.FromArgb(250, 250, 250);
            txtCompany.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompany.ForeColor = Color.FromArgb(15, 15, 15);
            txtCompany.Location = new Point(442, 183);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(200, 30);
            txtCompany.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(45, 45, 45);
            txtId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(250, 250, 250);
            txtId.Location = new Point(123, 236);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(92, 30);
            txtId.TabIndex = 13;
            txtId.Text = "0";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(250, 250, 250);
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(442, 125);
            txtPhone.Mask = "(00)00000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 30);
            txtPhone.TabIndex = 14;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(250, 250, 250);
            btnRegister.DialogResult = DialogResult.OK;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.FromArgb(15, 15, 15);
            btnRegister.Location = new Point(442, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.OK;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(549, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 47);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // ContactScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(696, 387);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(txtId);
            Controls.Add(txtCompany);
            Controls.Add(txtPosition);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContactScreenForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPosition;
        private TextBox txtCompany;
        private TextBox txtId;
        private MaskedTextBox txtPhone;
        private Button btnRegister;
        private Button btnCancel;
    }
}