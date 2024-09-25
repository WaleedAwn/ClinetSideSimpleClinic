namespace SimpleClinic_View.MedicalRecords.ListMedicalRecods
{
    partial class frmShowMedicalInfo
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
            panel1 = new Panel();
            btnClose = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ctrShowMedicalRecordss1 = new ctrMedicalRecords.ctrShowMedicalRecordss();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 308);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 48);
            panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(802, 0);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 48);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 68);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(ctrShowMedicalRecordss1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 240);
            panel3.TabIndex = 3;
            // 
            // ctrShowMedicalRecordss1
            // 
            ctrShowMedicalRecordss1.Dock = DockStyle.Fill;
            ctrShowMedicalRecordss1.Location = new Point(0, 0);
            ctrShowMedicalRecordss1.Name = "ctrShowMedicalRecordss1";
            ctrShowMedicalRecordss1.Size = new Size(920, 240);
            ctrShowMedicalRecordss1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(920, 68);
            label1.TabIndex = 1;
            label1.Text = "Show Medical Record Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmShowMedicalInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 356);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmShowMedicalInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmShowMedicalInfo";
            Load += frmShowMedicalInfo_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnClose;
        private Panel panel2;
        private Panel panel3;
        private ctrMedicalRecords.ctrShowMedicalRecordss ctrShowMedicalRecordss1;
        private Label label1;
    }
}