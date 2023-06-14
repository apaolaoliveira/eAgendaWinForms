namespace eAgenda.WinForms.TaskModule
{
    partial class FilterTaskScreenForm
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
            rdbDone = new RadioButton();
            rdbPending = new RadioButton();
            rdbAll = new RadioButton();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnRegister = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rdbDone
            // 
            rdbDone.AutoSize = true;
            rdbDone.Location = new Point(62, 205);
            rdbDone.Margin = new Padding(4, 6, 4, 6);
            rdbDone.Name = "rdbDone";
            rdbDone.Size = new Size(129, 34);
            rdbDone.TabIndex = 7;
            rdbDone.TabStop = true;
            rdbDone.Text = "Done Taks";
            rdbDone.TextAlign = ContentAlignment.MiddleRight;
            rdbDone.UseVisualStyleBackColor = true;
            // 
            // rdbPending
            // 
            rdbPending.AutoSize = true;
            rdbPending.Location = new Point(62, 130);
            rdbPending.Margin = new Padding(4, 6, 4, 6);
            rdbPending.Name = "rdbPending";
            rdbPending.Size = new Size(163, 34);
            rdbPending.TabIndex = 6;
            rdbPending.TabStop = true;
            rdbPending.Text = "Pending Tasks";
            rdbPending.TextAlign = ContentAlignment.MiddleRight;
            rdbPending.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Location = new Point(62, 55);
            rdbAll.Margin = new Padding(4, 6, 4, 6);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(112, 34);
            rdbAll.TabIndex = 5;
            rdbAll.TabStop = true;
            rdbAll.Text = "All Tasks";
            rdbAll.TextAlign = ContentAlignment.MiddleRight;
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbAll);
            groupBox1.Controls.Add(rdbDone);
            groupBox1.Controls.Add(rdbPending);
            groupBox1.ForeColor = Color.FromArgb(250, 250, 250);
            groupBox1.Location = new Point(44, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 289);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select View";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.OK;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(186, 356);
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
            btnRegister.Location = new Point(79, 356);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 30;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // FilterTaskScreenForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(343, 460);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Snow;
            Margin = new Padding(4);
            Name = "FilterTaskScreenForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Screen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdbDone;
        private RadioButton rdbPending;
        private RadioButton rdbAll;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnRegister;
    }
}