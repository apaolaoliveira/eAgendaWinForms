namespace eAgenda.WinForms.MainScreen
{
    partial class SerializationOptionsForm
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
            btnRegister = new Button();
            rbJson = new RadioButton();
            rbXml = new RadioButton();
            rbBin = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(250, 250, 250);
            btnRegister.DialogResult = DialogResult.OK;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.FromArgb(15, 15, 15);
            btnRegister.Location = new Point(26, 421);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(420, 47);
            btnRegister.TabIndex = 31;
            btnRegister.Text = "OK";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // rbJson
            // 
            rbJson.AutoSize = true;
            rbJson.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            rbJson.ForeColor = Color.FromArgb(250, 250, 250);
            rbJson.Location = new Point(26, 56);
            rbJson.Name = "rbJson";
            rbJson.Size = new Size(75, 34);
            rbJson.TabIndex = 32;
            rbJson.TabStop = true;
            rbJson.Text = ".json";
            rbJson.UseVisualStyleBackColor = true;
            // 
            // rbXml
            // 
            rbXml.AutoSize = true;
            rbXml.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            rbXml.ForeColor = Color.FromArgb(250, 250, 250);
            rbXml.Location = new Point(22, 175);
            rbXml.Name = "rbXml";
            rbXml.Size = new Size(72, 34);
            rbXml.TabIndex = 33;
            rbXml.TabStop = true;
            rbXml.Text = ".xml";
            rbXml.UseVisualStyleBackColor = true;
            // 
            // rbBin
            // 
            rbBin.AutoSize = true;
            rbBin.Font = new Font("Segoe UI", 12.5F, FontStyle.Italic, GraphicsUnit.Point);
            rbBin.ForeColor = Color.FromArgb(250, 250, 250);
            rbBin.Location = new Point(26, 294);
            rbBin.Name = "rbBin";
            rbBin.Size = new Size(67, 34);
            rbBin.TabIndex = 34;
            rbBin.TabStop = true;
            rbBin.Text = ".bin";
            rbBin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbBin);
            groupBox1.Controls.Add(rbJson);
            groupBox1.Controls.Add(rbXml);
            groupBox1.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(250, 250, 250);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 383);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose the file serialization format :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 58);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 35;
            label1.Text = "(recomended)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 95);
            label2.Name = "label2";
            label2.Size = new Size(297, 25);
            label2.TabIndex = 36;
            label2.Text = "It's better to set references, so every";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 218);
            label3.Name = "label3";
            label3.Size = new Size(308, 25);
            label3.TabIndex = 37;
            label3.Text = "After change a contact name it won't ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(58, 253);
            label4.Name = "label4";
            label4.Size = new Size(343, 25);
            label4.TabIndex = 38;
            label4.Text = "update the contact name on commitment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 127);
            label5.Name = "label5";
            label5.Size = new Size(279, 25);
            label5.TabIndex = 39;
            label5.Text = "change will be update everywhere";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 331);
            label6.Name = "label6";
            label6.Size = new Size(210, 25);
            label6.TabIndex = 40;
            label6.Text = "It's the same case of .xml";
            // 
            // SerializationOptionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(470, 480);
            Controls.Add(btnRegister);
            Controls.Add(groupBox1);
            Name = "SerializationOptionsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serialization Options";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private RadioButton rbJson;
        private RadioButton rbXml;
        private RadioButton rbBin;
        private GroupBox groupBox1;
        private Label label1;
        private HelpProvider helpProvider1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
    }
}