namespace eAgenda.WinForms.ContactModule
{
    partial class GridContactControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridContacts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridContacts).BeginInit();
            SuspendLayout();
            // 
            // gridContacts
            // 
            gridContacts.BackgroundColor = Color.FromArgb(15, 15, 15);
            gridContacts.BorderStyle = BorderStyle.None;
            gridContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridContacts.Dock = DockStyle.Fill;
            gridContacts.Location = new Point(0, 0);
            gridContacts.Name = "gridContacts";
            gridContacts.RowHeadersWidth = 51;
            gridContacts.RowTemplate.Height = 29;
            gridContacts.Size = new Size(882, 492);
            gridContacts.TabIndex = 0;
            // 
            // GridContactControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(gridContacts);
            ForeColor = Color.FromArgb(250, 250, 250);
            Name = "GridContactControl";
            Size = new Size(882, 492);
            ((System.ComponentModel.ISupportInitialize)gridContacts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridContacts;
    }
}
