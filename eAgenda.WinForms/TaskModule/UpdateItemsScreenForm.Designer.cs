namespace eAgenda.WinForms.TaskModule
{
    partial class UpdateItemsScreenForm
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
            listItemsTaks = new CheckedListBox();
            txtTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // listItemsTaks
            // 
            listItemsTaks.CheckOnClick = true;
            listItemsTaks.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listItemsTaks.FormattingEnabled = true;
            listItemsTaks.Location = new Point(111, 146);
            listItemsTaks.Margin = new Padding(4, 5, 4, 5);
            listItemsTaks.Name = "listItemsTaks";
            listItemsTaks.Size = new Size(365, 220);
            listItemsTaks.TabIndex = 24;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(111, 95);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(365, 32);
            txtTitle.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 20;
            label2.Text = "Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(48, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 30);
            label1.TabIndex = 18;
            label1.Text = "Id :";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(383, 407);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 47);
            btnCancel.TabIndex = 26;
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
            btnRegister.Location = new Point(276, 407);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 25;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(45, 45, 45);
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(250, 250, 250);
            txtId.Location = new Point(111, 45);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(365, 32);
            txtId.TabIndex = 33;
            txtId.Text = "0";
            // 
            // UpdateItemsScreenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(518, 494);
            Controls.Add(txtId);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(listItemsTaks);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Snow;
            Margin = new Padding(4);
            Name = "UpdateItemsScreenForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox listItemsTaks;
        private TextBox txtTitle;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnRegister;
        private TextBox txtId;
    }
}