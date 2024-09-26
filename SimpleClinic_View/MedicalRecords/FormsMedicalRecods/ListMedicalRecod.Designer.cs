namespace SimpleClinic_View.MedicalRecords.ListMedicalRecods
{
    partial class ListMedicalRecod
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
        private async void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMedicalRecod));
            panel1 = new Panel();
            panel4 = new Panel();
            pbAddNewMedicalRecord = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            muAddMedicalRecord = new ToolStripMenuItem();
            EditMedicalRecord = new ToolStripMenuItem();
            DeleteMedicalRecord = new ToolStripMenuItem();
            panel3 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddNewMedicalRecord).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 125);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbAddNewMedicalRecord);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(872, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(75, 125);
            panel4.TabIndex = 1;
            // 
            // pbAddNewMedicalRecord
            // 
            pbAddNewMedicalRecord.Dock = DockStyle.Bottom;
            pbAddNewMedicalRecord.Image = (Image)resources.GetObject("pbAddNewMedicalRecord.Image");
            pbAddNewMedicalRecord.Location = new Point(0, 61);
            pbAddNewMedicalRecord.Name = "pbAddNewMedicalRecord";
            pbAddNewMedicalRecord.Size = new Size(75, 64);
            pbAddNewMedicalRecord.TabIndex = 0;
            pbAddNewMedicalRecord.TabStop = false;
            pbAddNewMedicalRecord.Click += pbAddNewMedicalRecord_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(947, 125);
            label1.TabIndex = 0;
            label1.Text = "List Medical Records";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 433);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 70;
            dataGridView1.Size = new Size(947, 433);
            dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, muAddMedicalRecord, EditMedicalRecord, DeleteMedicalRecord });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(254, 124);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(253, 30);
            ShowDetailesToolStripMenuItem.Text = "Show Medical Record";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // muAddMedicalRecord
            // 
            muAddMedicalRecord.Image = (Image)resources.GetObject("muAddMedicalRecord.Image");
            muAddMedicalRecord.Name = "muAddMedicalRecord";
            muAddMedicalRecord.Size = new Size(253, 30);
            muAddMedicalRecord.Text = "Add new Medical Record";
            muAddMedicalRecord.Click += muAddMedicalRecord_Click;
            // 
            // EditMedicalRecord
            // 
            EditMedicalRecord.Image = (Image)resources.GetObject("EditMedicalRecord.Image");
            EditMedicalRecord.Name = "EditMedicalRecord";
            EditMedicalRecord.Size = new Size(253, 30);
            EditMedicalRecord.Text = "Edit Medical Record";
            EditMedicalRecord.Click += EditMedicalRecord_Click;
            // 
            // DeleteMedicalRecord
            // 
            DeleteMedicalRecord.Image = (Image)resources.GetObject("DeleteMedicalRecord.Image");
            DeleteMedicalRecord.Name = "DeleteMedicalRecord";
            DeleteMedicalRecord.Size = new Size(253, 30);
            DeleteMedicalRecord.Text = "Delete Medical Record";
            DeleteMedicalRecord.Click += DeleteMedicalRecord_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 513);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 45);
            panel3.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(829, 0);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 45);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ListMedicalRecod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(947, 558);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ListMedicalRecod";
            Text = "ListMedicalRecod";
            Load += ListMedicalRecod_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAddNewMedicalRecord).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button btnClose;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem muAddMedicalRecord;
        private ToolStripMenuItem EditMedicalRecord;
        private ToolStripMenuItem DeleteMedicalRecord;
        private Panel panel4;
        private PictureBox pbAddNewMedicalRecord;
    }
}