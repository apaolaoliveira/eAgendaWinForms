namespace eAgenda.WinForms
{
    partial class MainScreenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            registersToolStripMenuItem = new ToolStripMenuItem();
            contactMenuItem = new ToolStripMenuItem();
            commitmentMenuItem = new ToolStripMenuItem();
            taskMenuItem = new ToolStripMenuItem();
            expenseMenuItem = new ToolStripMenuItem();
            expensesMenuItem = new ToolStripMenuItem();
            categoryMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblFooter = new ToolStripStatusLabel();
            toolStrip = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnFilter = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAddItem = new ToolStripButton();
            btnCheckItem = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            lblRecordType = new ToolStripLabel();
            pnlRecords = new Panel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(250, 250, 250);
            menuStrip.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { registersToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1143, 50);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // registersToolStripMenuItem
            // 
            registersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contactMenuItem, commitmentMenuItem, taskMenuItem, expenseMenuItem });
            registersToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            registersToolStripMenuItem.ForeColor = Color.FromArgb(15, 15, 15);
            registersToolStripMenuItem.Image = Properties.Resources.recordsIcon;
            registersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            registersToolStripMenuItem.Margin = new Padding(5);
            registersToolStripMenuItem.Name = "registersToolStripMenuItem";
            registersToolStripMenuItem.Size = new Size(124, 36);
            registersToolStripMenuItem.Text = "Records";
            // 
            // contactMenuItem
            // 
            contactMenuItem.Image = Properties.Resources.contactIcon;
            contactMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            contactMenuItem.Name = "contactMenuItem";
            contactMenuItem.Size = new Size(219, 38);
            contactMenuItem.Text = "Contact";
            contactMenuItem.Click += contactMenuItem_Click;
            // 
            // commitmentMenuItem
            // 
            commitmentMenuItem.Image = Properties.Resources.commitmentIcon;
            commitmentMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            commitmentMenuItem.Name = "commitmentMenuItem";
            commitmentMenuItem.Size = new Size(219, 38);
            commitmentMenuItem.Text = "Commitment";
            commitmentMenuItem.Click += commitmentMenuItem_Click;
            // 
            // taskMenuItem
            // 
            taskMenuItem.Image = Properties.Resources.taskIcon;
            taskMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            taskMenuItem.Name = "taskMenuItem";
            taskMenuItem.Size = new Size(219, 38);
            taskMenuItem.Text = "Task";
            taskMenuItem.Click += taskMenuItem_Click;
            // 
            // expenseMenuItem
            // 
            expenseMenuItem.DropDownItems.AddRange(new ToolStripItem[] { expensesMenuItem, categoryMenuItem });
            expenseMenuItem.Image = Properties.Resources.expenseIcon;
            expenseMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            expenseMenuItem.Name = "expenseMenuItem";
            expenseMenuItem.Size = new Size(219, 38);
            expenseMenuItem.Text = "Expense";
            expenseMenuItem.Click += expenseMenuItem_Click;
            // 
            // expensesMenuItem
            // 
            expensesMenuItem.Image = Properties.Resources.expenseIcon2;
            expensesMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            expensesMenuItem.Name = "expensesMenuItem";
            expensesMenuItem.Size = new Size(186, 38);
            expensesMenuItem.Text = "Expense";
            // 
            // categoryMenuItem
            // 
            categoryMenuItem.Image = Properties.Resources.categoryIcon;
            categoryMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            categoryMenuItem.Name = "categoryMenuItem";
            categoryMenuItem.Size = new Size(186, 38);
            categoryMenuItem.Text = "Category";
            categoryMenuItem.Click += categoryMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblFooter });
            statusStrip.Location = new Point(0, 653);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1143, 22);
            statusStrip.TabIndex = 1;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.FromArgb(250, 250, 250);
            lblFooter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFooter.ForeColor = Color.FromArgb(15, 15, 15);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(0, 16);
            // 
            // toolStrip
            // 
            toolStrip.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip.GripMargin = new Padding(5);
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { btnAdd, btnUpdate, btnDelete, toolStripSeparator2, btnFilter, toolStripSeparator1, btnAddItem, btnCheckItem, toolStripSeparator3, lblRecordType });
            toolStrip.Location = new Point(0, 50);
            toolStrip.Margin = new Padding(5);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(2);
            toolStrip.Size = new Size(1143, 54);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources.addIcon;
            btnAdd.ImageScaling = ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(2);
            btnAdd.Size = new Size(40, 40);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUpdate.Image = Properties.Resources.updateIcon;
            btnUpdate.ImageScaling = ToolStripItemImageScaling.None;
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(2);
            btnUpdate.Size = new Size(40, 40);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources.deleteIcon;
            btnDelete.ImageScaling = ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(2);
            btnDelete.Size = new Size(40, 40);
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 50);
            // 
            // btnFilter
            // 
            btnFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFilter.Image = Properties.Resources.filterIcon;
            btnFilter.ImageScaling = ToolStripItemImageScaling.None;
            btnFilter.ImageTransparentColor = Color.Magenta;
            btnFilter.Margin = new Padding(5);
            btnFilter.Name = "btnFilter";
            btnFilter.Padding = new Padding(2);
            btnFilter.Size = new Size(40, 40);
            btnFilter.Click += btnFilter_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(15, 15, 15);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
            // 
            // btnAddItem
            // 
            btnAddItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddItem.Image = Properties.Resources.addItemIcon;
            btnAddItem.ImageScaling = ToolStripItemImageScaling.None;
            btnAddItem.ImageTransparentColor = Color.Magenta;
            btnAddItem.Margin = new Padding(5);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Padding = new Padding(2);
            btnAddItem.Size = new Size(40, 40);
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnCheckItem
            // 
            btnCheckItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCheckItem.Image = Properties.Resources.checkItemIcon;
            btnCheckItem.ImageScaling = ToolStripItemImageScaling.None;
            btnCheckItem.ImageTransparentColor = Color.Magenta;
            btnCheckItem.Margin = new Padding(5);
            btnCheckItem.Name = "btnCheckItem";
            btnCheckItem.Size = new Size(36, 40);
            btnCheckItem.Click += btnCheckItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 50);
            // 
            // lblRecordType
            // 
            lblRecordType.ForeColor = Color.FromArgb(15, 15, 15);
            lblRecordType.Name = "lblRecordType";
            lblRecordType.Size = new Size(114, 47);
            lblRecordType.Text = "Record Type";
            // 
            // pnlRecords
            // 
            pnlRecords.BorderStyle = BorderStyle.Fixed3D;
            pnlRecords.Dock = DockStyle.Fill;
            pnlRecords.Location = new Point(0, 104);
            pnlRecords.Name = "pnlRecords";
            pnlRecords.Size = new Size(1143, 549);
            pnlRecords.TabIndex = 3;
            // 
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1143, 675);
            Controls.Add(pnlRecords);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            ForeColor = Color.FromArgb(250, 250, 250);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip;
            Name = "MainScreenForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem registersToolStripMenuItem;
        private ToolStripMenuItem contactMenuItem;
        private ToolStripMenuItem commitmentMenuItem;
        private ToolStripMenuItem taskMenuItem;
        private ToolStripMenuItem expenseMenuItem;
        private ToolStripMenuItem expensesMenuItem;
        private ToolStripMenuItem categoryMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblFooter;
        private ToolStrip toolStrip;
        private ToolStripButton btnAdd;
        private ToolStripButton btnUpdate;
        private ToolStripButton btnDelete;
        private Panel pnlRecords;
        private ToolStripButton btnFilter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblRecordType;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAddItem;
        private ToolStripButton btnCheckItem;
        private ToolStripSeparator toolStripSeparator3;
    }
}