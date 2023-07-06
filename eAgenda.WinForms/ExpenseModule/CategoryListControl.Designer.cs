namespace eAgenda.WinForms.ExpenseModule
{
    partial class CategoryListControl
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
            categoriesList = new ListView();
            SuspendLayout();
            // 
            // categoriesList
            // 
            categoriesList.BackColor = Color.FromArgb(250, 250, 250);
            categoriesList.Dock = DockStyle.Fill;
            categoriesList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesList.Location = new Point(0, 0);
            categoriesList.Name = "categoriesList";
            categoriesList.Size = new Size(772, 468);
            categoriesList.TabIndex = 0;
            categoriesList.UseCompatibleStateImageBehavior = false;
            // 
            // CategoryListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(categoriesList);
            Name = "CategoryListControl";
            Size = new Size(772, 468);
            ResumeLayout(false);
        }

        #endregion

        private ListView categoriesList;
    }
}
