namespace eAgenda.WinForms.TaskModule
{
    partial class RecordItemsScreenForm
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
            btnAdd = new Button();
            txtDescription = new TextBox();
            label3 = new Label();
            listItems = new ListBox();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            txtId = new TextBox();
            btnRemove = new Button();
            txtTitle = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(15, 15, 15);
            btnAdd.Location = new Point(152, 173);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(191, 37);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(152, 128);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(405, 32);
            txtDescription.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(17, 130);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 25;
            label3.Text = "Description :";
            // 
            // listItems
            // 
            listItems.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            listItems.FormattingEnabled = true;
            listItems.ItemHeight = 25;
            listItems.Location = new Point(152, 223);
            listItems.Margin = new Padding(3, 4, 3, 4);
            listItems.Name = "listItems";
            listItems.Size = new Size(405, 229);
            listItems.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(79, 82);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 22;
            label2.Text = "Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(96, 38);
            label1.Name = "label1";
            label1.Size = new Size(45, 30);
            label1.TabIndex = 20;
            label1.Text = "ID :";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(15, 15, 15);
            btnCancel.Location = new Point(464, 476);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 47);
            btnCancel.TabIndex = 29;
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
            btnRegister.Location = new Point(357, 476);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 47);
            btnRegister.TabIndex = 28;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(45, 45, 45);
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(250, 250, 250);
            txtId.Location = new Point(152, 38);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(405, 32);
            txtId.TabIndex = 30;
            txtId.Text = "0";
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.FromArgb(15, 15, 15);
            btnRemove.Location = new Point(366, 173);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(191, 37);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(45, 45, 45);
            txtTitle.Enabled = false;
            txtTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.FromArgb(250, 250, 250);
            txtTitle.Location = new Point(152, 82);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(405, 32);
            txtTitle.TabIndex = 32;
            // 
            // RecordItemsScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(604, 561);
            Controls.Add(txtTitle);
            Controls.Add(btnRemove);
            Controls.Add(txtId);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(listItems);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Snow;
            Name = "RecordItemsScreenForm";
            ShowIcon = false;
            Text = "Items Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtDescription;
        private Label label3;
        private ListBox listItems;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnRegister;
        private TextBox txtId;
        private Button btnRemove;
        private TextBox txtTitle;
    }
}