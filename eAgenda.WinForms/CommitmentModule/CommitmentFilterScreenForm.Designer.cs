namespace eAgenda.WinForms.CommitmentModule
{
    partial class CommitmentFilterScreenForm
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
            txtEndDate = new DateTimePicker();
            txtStartDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            groupBox1 = new GroupBox();
            rdbFuture = new RadioButton();
            rdbAll = new RadioButton();
            rdbPast = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEndDate
            // 
            txtEndDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.CustomFormat = "";
            txtEndDate.Format = DateTimePickerFormat.Short;
            txtEndDate.Location = new Point(168, 291);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(194, 27);
            txtEndDate.TabIndex = 27;
            txtEndDate.Value = new DateTime(2023, 6, 6, 12, 0, 0, 0);
            // 
            // txtStartDate
            // 
            txtStartDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.CustomFormat = "";
            txtStartDate.Format = DateTimePickerFormat.Short;
            txtStartDate.Location = new Point(168, 233);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(194, 27);
            txtStartDate.TabIndex = 26;
            txtStartDate.Value = new DateTime(2023, 6, 6, 12, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(250, 250, 250);
            label3.Location = new Point(55, 288);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 25;
            label3.Text = "End Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(250, 250, 250);
            label2.Location = new Point(45, 230);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 24;
            label2.Text = "Start Date :";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.OK;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(269, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 39);
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
            btnRegister.Location = new Point(168, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(89, 39);
            btnRegister.TabIndex = 29;
            btnRegister.Text = "OK";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFuture);
            groupBox1.Controls.Add(rdbAll);
            groupBox1.Controls.Add(rdbPast);
            groupBox1.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(250, 250, 250);
            groupBox1.Location = new Point(49, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 170);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "View";
            // 
            // rdbFuture
            // 
            rdbFuture.AutoSize = true;
            rdbFuture.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            rdbFuture.ForeColor = Color.FromArgb(250, 250, 250);
            rdbFuture.Location = new Point(64, 117);
            rdbFuture.Name = "rdbFuture";
            rdbFuture.Size = new Size(225, 34);
            rdbFuture.TabIndex = 36;
            rdbFuture.TabStop = true;
            rdbFuture.Text = "Future Commitments";
            rdbFuture.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            rdbAll.ForeColor = Color.FromArgb(250, 250, 250);
            rdbAll.Location = new Point(64, 34);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(190, 34);
            rdbAll.TabIndex = 34;
            rdbAll.TabStop = true;
            rdbAll.Text = "All Commitments";
            rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbPast
            // 
            rdbPast.AutoSize = true;
            rdbPast.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            rdbPast.ForeColor = Color.FromArgb(250, 250, 250);
            rdbPast.Location = new Point(64, 74);
            rdbPast.Name = "rdbPast";
            rdbPast.Size = new Size(205, 34);
            rdbPast.TabIndex = 35;
            rdbPast.TabStop = true;
            rdbPast.Text = "Past Commitments";
            rdbPast.UseVisualStyleBackColor = true;
            // 
            // CommitmentFilterScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(417, 449);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CommitmentFilterScreenForm";
            Text = "Commitment Filter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker txtEndDate;
        private DateTimePicker txtStartDate;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnRegister;
        private GroupBox groupBox1;
        private RadioButton rdbFuture;
        private RadioButton rdbAll;
        private RadioButton rdbPast;
    }
}