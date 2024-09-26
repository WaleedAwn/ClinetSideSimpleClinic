namespace SimpleClinic_View.Preception.FormsPreception
{
    partial class frmListPerception
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPerception));
            panel1 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            dgvPreception = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowPreceptionInfo = new ToolStripMenuItem();
            AddNewPreception = new ToolStripMenuItem();
            EditPreception = new ToolStripMenuItem();
            DeletePreception = new ToolStripMenuItem();
            panel3 = new Panel();
            panel7 = new Panel();
            lblRowCount = new Label();
            label2 = new Label();
            panel6 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreception).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 74);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(139, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(776, 74);
            panel8.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(776, 74);
            label1.TabIndex = 2;
            label1.Text = "List Preception Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(915, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(132, 74);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(139, 74);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPreception);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 606);
            panel2.TabIndex = 1;
            // 
            // dgvPreception
            // 
            dgvPreception.AllowUserToAddRows = false;
            dgvPreception.AllowUserToDeleteRows = false;
            dgvPreception.BackgroundColor = SystemColors.ControlLightLight;
            dgvPreception.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreception.ContextMenuStrip = contextMenuStrip1;
            dgvPreception.Dock = DockStyle.Fill;
            dgvPreception.Location = new Point(0, 0);
            dgvPreception.Name = "dgvPreception";
            dgvPreception.ReadOnly = true;
            dgvPreception.RowHeadersWidth = 51;
            dgvPreception.Size = new Size(1047, 606);
            dgvPreception.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ShowPreceptionInfo, AddNewPreception, EditPreception, DeletePreception });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(254, 152);
            // 
            // ShowPreceptionInfo
            // 
            ShowPreceptionInfo.Image = (Image)resources.GetObject("ShowPreceptionInfo.Image");
            ShowPreceptionInfo.Name = "ShowPreceptionInfo";
            ShowPreceptionInfo.Size = new Size(253, 30);
            ShowPreceptionInfo.Text = "Show Medical Record";
            ShowPreceptionInfo.Click += ShowPreceptionInfo_Click;
            // 
            // AddNewPreception
            // 
            AddNewPreception.Image = (Image)resources.GetObject("AddNewPreception.Image");
            AddNewPreception.Name = "AddNewPreception";
            AddNewPreception.Size = new Size(253, 30);
            AddNewPreception.Text = "Add new Medical Record";
            AddNewPreception.Click += AddNewPreception_Click;
            // 
            // EditPreception
            // 
            EditPreception.Image = (Image)resources.GetObject("EditPreception.Image");
            EditPreception.Name = "EditPreception";
            EditPreception.Size = new Size(253, 30);
            EditPreception.Text = "Edit Medical Record";
            EditPreception.Click += EditPreception_Click;
            // 
            // DeletePreception
            // 
            DeletePreception.Image = (Image)resources.GetObject("DeletePreception.Image");
            DeletePreception.Name = "DeletePreception";
            DeletePreception.Size = new Size(253, 30);
            DeletePreception.Text = "Delete Medical Record";
            DeletePreception.Click += DeletePreception_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 629);
            panel3.Name = "panel3";
            panel3.Size = new Size(1047, 51);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblRowCount);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(139, 51);
            panel7.TabIndex = 1;
            // 
            // lblRowCount
            // 
            lblRowCount.Dock = DockStyle.Left;
            lblRowCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRowCount.Location = new Point(80, 0);
            lblRowCount.Name = "lblRowCount";
            lblRowCount.Size = new Size(56, 51);
            lblRowCount.TabIndex = 1;
            lblRowCount.Text = "[???]";
            lblRowCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 51);
            label2.TabIndex = 0;
            label2.Text = "#Record :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnClose);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(915, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(132, 51);
            panel6.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Dock = DockStyle.Fill;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(0, 0);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 51);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmListPerception
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 680);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmListPerception";
            Text = "frmListPerception";
            Load += frmListPerception_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPreception).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel8;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private DataGridView dgvPreception;
        private Panel panel3;
        private Panel panel7;
        private Panel panel6;
        private Label label1;
        private Label label2;
        private Button btnClose;
        private Label lblRowCount;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowPreceptionInfo;
        private ToolStripMenuItem AddNewPreception;
        private ToolStripMenuItem EditPreception;
        private ToolStripMenuItem DeletePreception;
    }
}