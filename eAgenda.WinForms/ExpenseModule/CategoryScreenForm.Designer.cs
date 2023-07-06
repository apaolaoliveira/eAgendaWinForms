namespace eAgenda.WinForms.ExpenseModule
{
    partial class CategoryScreenForm
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
            txtTitle = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(250, 250, 250);
            txtTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.FromArgb(15, 15, 15);
            txtTitle.Location = new Point(87, 121);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(238, 32);
            txtTitle.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(45, 45, 45);
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(250, 250, 250);
            txtId.Location = new Point(87, 66);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(238, 32);
            txtId.TabIndex = 19;
            txtId.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(250, 250, 250);
            label6.Location = new Point(39, 63);
            label6.Name = "label6";
            label6.Size = new Size(41, 30);
            label6.TabIndex = 18;
            label6.Text = "Id :";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(211, 191);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 47);
            btnCancel.TabIndex = 30;
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
            btnRegister.Location = new Point(104, 191);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 29;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(250, 250, 250);
            label1.Location = new Point(19, 121);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 31;
            label1.Text = "Title :";
            // 
            // CategoryScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(379, 299);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(label6);
            ForeColor = Color.FromArgb(250, 250, 250);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryScreenForm";
            Text = "CategoryScreenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtId;
        private Label label6;
        private Button btnCancel;
        private Button btnRegister;
        private Label label1;
    }
}