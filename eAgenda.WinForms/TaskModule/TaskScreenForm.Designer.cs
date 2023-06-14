namespace eAgenda.WinForms.TaskModule
{
    partial class TaskScreenForm
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
            txtCreationDate = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            cmbPriority = new ComboBox();
            txtTitle = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtCreationDate
            // 
            txtCreationDate.Format = DateTimePickerFormat.Short;
            txtCreationDate.Location = new Point(485, 136);
            txtCreationDate.Margin = new Padding(3, 4, 3, 4);
            txtCreationDate.Name = "txtCreationDate";
            txtCreationDate.Size = new Size(171, 35);
            txtCreationDate.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 140);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 20;
            label4.Text = "Creation Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 136);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 19;
            label3.Text = "Priority :";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(151, 133);
            cmbPriority.Margin = new Padding(3, 4, 3, 4);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(138, 38);
            cmbPriority.TabIndex = 18;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(151, 87);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(505, 35);
            txtTitle.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 92);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 16;
            label2.Text = "Title :";
            // 
            // txtId
            // 
            txtId.Location = new Point(151, 43);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(92, 35);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 30);
            label1.TabIndex = 14;
            label1.Text = "ID :";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.OK;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(562, 214);
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
            btnRegister.Location = new Point(455, 214);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 30;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // TaskScreenForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(698, 300);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtCreationDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbPriority);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Snow;
            Margin = new Padding(4);
            Name = "TaskScreenForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskScreenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker txtCreationDate;
        private Label label4;
        private Label label3;
        private ComboBox cmbPriority;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnCancel;
        private Button btnRegister;
    }
}