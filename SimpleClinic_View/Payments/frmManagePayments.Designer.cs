namespace SimpleClinic_View.Payments
{
    partial class frmManagePayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePayments));
            pbMangePayments = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            dgvListAllPayments = new DataGridView();
            label3 = new Label();
            txtFilter = new TextBox();
            cbFilterBy = new ComboBox();
            btnAddNew = new PictureBox();
            btnClose = new Button();
            lblCounter = new Label();
            label2 = new Label();
            cmsPaymentMenu = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbMangePayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAllPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddNew).BeginInit();
            cmsPaymentMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pbMangePayments
            // 
            pbMangePayments.BackColor = Color.Transparent;
            pbMangePayments.Image = (Image)resources.GetObject("pbMangePayments.Image");
            pbMangePayments.Location = new Point(417, -2);
            pbMangePayments.Margin = new Padding(2);
            pbMangePayments.Name = "pbMangePayments";
            pbMangePayments.Size = new Size(277, 112);
            pbMangePayments.SizeMode = PictureBoxSizeMode.Zoom;
            pbMangePayments.TabIndex = 18;
            pbMangePayments.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(419, 107);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 19;
            label1.Text = "Manage Payments";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(560, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvListAllPayments);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 264);
            panel1.TabIndex = 21;
            // 
            // dgvListAllPayments
            // 
            dgvListAllPayments.AllowUserToAddRows = false;
            dgvListAllPayments.AllowUserToDeleteRows = false;
            dgvListAllPayments.AllowUserToOrderColumns = true;
            dgvListAllPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListAllPayments.BackgroundColor = Color.White;
            dgvListAllPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllPayments.ContextMenuStrip = cmsPaymentMenu;
            dgvListAllPayments.Dock = DockStyle.Fill;
            dgvListAllPayments.Location = new Point(0, 0);
            dgvListAllPayments.Name = "dgvListAllPayments";
            dgvListAllPayments.ReadOnly = true;
            dgvListAllPayments.RowHeadersWidth = 51;
            dgvListAllPayments.Size = new Size(1218, 264);
            dgvListAllPayments.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 26;
            label3.Text = "Filter By:";
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 12F);
            txtFilter.Location = new Point(320, 179);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(211, 34);
            txtFilter.TabIndex = 25;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Segoe UI", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Id", "Patient Name", "Method Id", "Payment Method", "Amount Paid", "Additional Notes" });
            cbFilterBy.Location = new Point(104, 179);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(210, 36);
            cbFilterBy.TabIndex = 27;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // btnAddNew
            // 
            btnAddNew.BackgroundImage = (Image)resources.GetObject("btnAddNew.BackgroundImage");
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.BorderStyle = BorderStyle.FixedSingle;
            btnAddNew.Location = new Point(1152, 166);
            btnAddNew.Margin = new Padding(2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(78, 60);
            btnAddNew.TabIndex = 28;
            btnAddNew.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1086, 497);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 40);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCounter.Location = new Point(125, 498);
            lblCounter.Margin = new Padding(2, 0, 2, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(24, 28);
            lblCounter.TabIndex = 31;
            lblCounter.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 498);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 30;
            label2.Text = "# Records:";
            // 
            // cmsPaymentMenu
            // 
            cmsPaymentMenu.ImageScalingSize = new Size(24, 24);
            cmsPaymentMenu.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1 });
            cmsPaymentMenu.Name = "contextMenuStrip1";
            cmsPaymentMenu.Size = new Size(214, 156);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(213, 38);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = (Image)resources.GetObject("AddNewToolStripMenuItem.Image");
            AddNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(213, 38);
            AddNewToolStripMenuItem.Text = "Add new Payment";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(213, 38);
            EditToolStripMenuItem.Text = "Edit Payment";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.Delete_User_32;
            deleteToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(213, 38);
            deleteToolStripMenuItem1.Text = "Delete Payment";
            // 
            // frmManagePayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1242, 544);
            Controls.Add(lblCounter);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnAddNew);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(cbFilterBy);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pbMangePayments);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManagePayments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Payments";
            Load += frmManagePayments_Load;
            ((System.ComponentModel.ISupportInitialize)pbMangePayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListAllPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddNew).EndInit();
            cmsPaymentMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMangePayments;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private DataGridView dgvListAllPayments;
        private Label label3;
        private TextBox txtFilter;
        private ComboBox cbFilterBy;
        private PictureBox btnAddNew;
        private Button btnClose;
        private Label lblCounter;
        private Label label2;
        private ContextMenuStrip cmsPaymentMenu;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
    }
}