namespace eAgenda.WinForms.CommitmentModule
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
            txtId = new TextBox();
            label6 = new Label();
            txtSubject = new TextBox();
            lblSubject = new Label();
            label1 = new Label();
            txtDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtStartTime = new DateTimePicker();
            txtEndTime = new DateTimePicker();
            chkSelectContact = new CheckBox();
            label4 = new Label();
            groupBoxLocation = new GroupBox();
            txtOnline = new TextBox();
            txtInPerson = new TextBox();
            rdbOnline = new RadioButton();
            rdbInPerson = new RadioButton();
            cmbContacts = new ComboBox();
            btnCancel = new Button();
            btnRegister = new Button();
            groupBoxLocation.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(45, 45, 45);
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(250, 250, 250);
            txtId.Location = new Point(502, 115);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(230, 32);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(250, 250, 250);
            label6.Location = new Point(454, 112);
            label6.Name = "label6";
            label6.Size = new Size(41, 30);
            label6.TabIndex = 14;
            label6.Text = "Id :";
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.FromArgb(250, 250, 250);
            txtSubject.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubject.ForeColor = Color.FromArgb(15, 15, 15);
            txtSubject.Location = new Point(145, 53);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(587, 32);
            txtSubject.TabIndex = 17;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            lblSubject.ForeColor = Color.FromArgb(250, 250, 250);
            lblSubject.Location = new Point(51, 53);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(88, 30);
            lblSubject.TabIndex = 16;
            lblSubject.Text = "Subject :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(250, 250, 250);
            label1.Location = new Point(71, 115);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 18;
            label1.Text = "Date :";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Format = DateTimePickerFormat.Short;
            txtDate.Location = new Point(144, 115);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(231, 32);
            txtDate.TabIndex = 19;
            txtDate.Value = new DateTime(2023, 6, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(250, 250, 250);
            label2.Location = new Point(22, 181);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 20;
            label2.Text = "Start Time :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(250, 250, 250);
            label3.Location = new Point(389, 181);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 21;
            label3.Text = "End Time :";
            // 
            // txtStartTime
            // 
            txtStartTime.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartTime.CustomFormat = "HH:mm";
            txtStartTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartTime.Format = DateTimePickerFormat.Custom;
            txtStartTime.Location = new Point(145, 184);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(230, 32);
            txtStartTime.TabIndex = 22;
            txtStartTime.Value = new DateTime(2023, 6, 6, 12, 0, 0, 0);
            // 
            // txtEndTime
            // 
            txtEndTime.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndTime.CustomFormat = "HH:mm";
            txtEndTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndTime.Format = DateTimePickerFormat.Custom;
            txtEndTime.Location = new Point(502, 184);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new Size(230, 32);
            txtEndTime.TabIndex = 23;
            txtEndTime.Value = new DateTime(2023, 6, 6, 18, 0, 0, 0);
            // 
            // chkSelectContact
            // 
            chkSelectContact.AutoSize = true;
            chkSelectContact.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            chkSelectContact.ForeColor = Color.FromArgb(250, 250, 250);
            chkSelectContact.Location = new Point(224, 250);
            chkSelectContact.Name = "chkSelectContact";
            chkSelectContact.RightToLeft = RightToLeft.Yes;
            chkSelectContact.Size = new Size(151, 34);
            chkSelectContact.TabIndex = 24;
            chkSelectContact.Text = "?Add contact";
            chkSelectContact.UseVisualStyleBackColor = true;
            chkSelectContact.CheckedChanged += chkSelectContact_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(250, 250, 250);
            label4.Location = new Point(401, 252);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 25;
            label4.Text = "Contact :";
            // 
            // groupBoxLocation
            // 
            groupBoxLocation.Controls.Add(txtOnline);
            groupBoxLocation.Controls.Add(txtInPerson);
            groupBoxLocation.Controls.Add(rdbOnline);
            groupBoxLocation.Controls.Add(rdbInPerson);
            groupBoxLocation.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            groupBoxLocation.ForeColor = Color.FromArgb(250, 250, 250);
            groupBoxLocation.Location = new Point(145, 307);
            groupBoxLocation.Name = "groupBoxLocation";
            groupBoxLocation.Size = new Size(587, 144);
            groupBoxLocation.TabIndex = 26;
            groupBoxLocation.TabStop = false;
            groupBoxLocation.Text = "Local";
            // 
            // txtOnline
            // 
            txtOnline.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtOnline.Location = new Point(223, 89);
            txtOnline.Margin = new Padding(3, 4, 3, 4);
            txtOnline.Name = "txtOnline";
            txtOnline.Size = new Size(279, 32);
            txtOnline.TabIndex = 29;
            // 
            // txtInPerson
            // 
            txtInPerson.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtInPerson.Location = new Point(223, 35);
            txtInPerson.Margin = new Padding(3, 4, 3, 4);
            txtInPerson.Name = "txtInPerson";
            txtInPerson.Size = new Size(279, 32);
            txtInPerson.TabIndex = 27;
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Location = new Point(112, 86);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(105, 34);
            rdbOnline.TabIndex = 28;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online :";
            rdbOnline.UseVisualStyleBackColor = true;
            rdbOnline.CheckedChanged += rdbOnline_CheckedChanged;
            // 
            // rdbInPerson
            // 
            rdbInPerson.AutoSize = true;
            rdbInPerson.Location = new Point(86, 35);
            rdbInPerson.Name = "rdbInPerson";
            rdbInPerson.Size = new Size(131, 34);
            rdbInPerson.TabIndex = 27;
            rdbInPerson.TabStop = true;
            rdbInPerson.Text = "In-Person :";
            rdbInPerson.UseVisualStyleBackColor = true;
            rdbInPerson.CheckedChanged += rdbInPerson_CheckedChanged;
            // 
            // cmbContacts
            // 
            cmbContacts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContacts.Enabled = false;
            cmbContacts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbContacts.FormattingEnabled = true;
            cmbContacts.Location = new Point(501, 252);
            cmbContacts.Name = "cmbContacts";
            cmbContacts.Size = new Size(230, 33);
            cmbContacts.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(639, 489);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 47);
            btnCancel.TabIndex = 28;
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
            btnRegister.Location = new Point(532, 489);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 27;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // CategoryScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(783, 576);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(cmbContacts);
            Controls.Add(groupBoxLocation);
            Controls.Add(label4);
            Controls.Add(chkSelectContact);
            Controls.Add(txtEndTime);
            Controls.Add(txtStartTime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDate);
            Controls.Add(label1);
            Controls.Add(txtSubject);
            Controls.Add(lblSubject);
            Controls.Add(txtId);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryScreenForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new Commitment";
            groupBoxLocation.ResumeLayout(false);
            groupBoxLocation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label6;
        private TextBox txtSubject;
        private Label lblSubject;
        private Label label1;
        private DateTimePicker txtDate;
        private Label label2;
        private Label label3;
        private DateTimePicker txtStartTime;
        private DateTimePicker txtEndTime;
        private CheckBox chkSelectContact;
        private Label label4;
        private GroupBox groupBoxLocation;
        private ComboBox cmbContacts;
        private RadioButton rdbOnline;
        private RadioButton rdbInPerson;
        private TextBox txtOnline;
        private TextBox txtInPerson;
        private Button btnCancel;
        private Button btnRegister;
    }
}