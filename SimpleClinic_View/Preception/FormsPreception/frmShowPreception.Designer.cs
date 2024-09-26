namespace SimpleClinic_View.Preception.FormsPreception
{
    partial class frmShowPreception
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
            label1 = new Label();
            panel2 = new Panel();
            ctrShowPreception1 = new Controls.ctrShowPreception();
            panel3 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(777, 72);
            label1.TabIndex = 2;
            label1.Text = "Show Preception Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(ctrShowPreception1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 297);
            panel2.TabIndex = 1;
            // 
            // ctrShowPreception1
            // 
            ctrShowPreception1.Dock = DockStyle.Fill;
            ctrShowPreception1.Location = new Point(0, 0);
            ctrShowPreception1.Name = "ctrShowPreception1";
            ctrShowPreception1.Size = new Size(777, 297);
            ctrShowPreception1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(777, 46);
            panel3.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(659, 0);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 46);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowPreception
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 369);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmShowPreception";
            Text = "frmShowPreception";
            Load += frmShowPreception_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Controls.ctrShowPreception ctrShowPreception1;
        private Panel panel3;
        private Label label1;
        private Button btnClose;
    }
}