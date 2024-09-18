namespace SimpleClinic_View.Users
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            label1 = new Label();
            pbManagePeople = new PictureBox();
            panel1 = new Panel();
            dgvListAllUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colPersonId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            lblCounter = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            cbFilter = new ComboBox();
            cmsUserMenu = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAllUsers).BeginInit();
            cmsUserMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.Location = new Point(398, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 36);
            label1.TabIndex = 3;
            label1.Text = "Manage Users";
            // 
            // pbManagePeople
            // 
            pbManagePeople.BackColor = Color.Transparent;
            pbManagePeople.Image = Properties.Resources.Users_2_400;
            pbManagePeople.Location = new Point(398, 0);
            pbManagePeople.Margin = new Padding(2);
            pbManagePeople.Name = "pbManagePeople";
            pbManagePeople.Size = new Size(207, 116);
            pbManagePeople.SizeMode = PictureBoxSizeMode.Zoom;
            pbManagePeople.TabIndex = 2;
            pbManagePeople.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvListAllUsers);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 264);
            panel1.TabIndex = 4;
            // 
            // dgvListAllUsers
            // 
            dgvListAllUsers.AllowUserToAddRows = false;
            dgvListAllUsers.AllowUserToDeleteRows = false;
            dgvListAllUsers.AllowUserToOrderColumns = true;
            dgvListAllUsers.BackgroundColor = Color.White;
            dgvListAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colPersonId, colFullName, colUserName });
            dgvListAllUsers.ContextMenuStrip = cmsUserMenu;
            dgvListAllUsers.Dock = DockStyle.Fill;
            dgvListAllUsers.Location = new Point(0, 0);
            dgvListAllUsers.Name = "dgvListAllUsers";
            dgvListAllUsers.ReadOnly = true;
            dgvListAllUsers.RowHeadersWidth = 51;
            dgvListAllUsers.Size = new Size(868, 264);
            dgvListAllUsers.TabIndex = 0;
            // 
            // colUserId
            // 
            colUserId.HeaderText = "User Id";
            colUserId.MinimumWidth = 6;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Width = 125;
            // 
            // colPersonId
            // 
            colPersonId.HeaderText = "Person Id";
            colPersonId.MinimumWidth = 6;
            colPersonId.Name = "colPersonId";
            colPersonId.ReadOnly = true;
            colPersonId.Width = 125;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 300;
            // 
            // colUserName
            // 
            colUserName.HeaderText = "UserName";
            colUserName.MinimumWidth = 6;
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            colUserName.Width = 125;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(758, 492);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 33);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblCounter.Location = new Point(69, 498);
            lblCounter.Margin = new Padding(2, 0, 2, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(15, 16);
            lblCounter.TabIndex = 11;
            lblCounter.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 498);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 10;
            label2.Text = "# Records:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(266, 176);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(211, 34);
            txtSearch.TabIndex = 12;
            txtSearch.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 13;
            label3.Text = "Filter:";
            // 
            // cbFilter
            // 
            cbFilter.Font = new Font("Segoe UI", 12F);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "User Id", "Person Id", "Full Name", "UserName" });
            cbFilter.Location = new Point(78, 176);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(179, 36);
            cbFilter.TabIndex = 14;
            // 
            // cmsUserMenu
            // 
            cmsUserMenu.ImageScalingSize = new Size(24, 24);
            cmsUserMenu.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1 });
            cmsUserMenu.Name = "contextMenuStrip1";
            cmsUserMenu.Size = new Size(227, 184);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(226, 38);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = (Image)resources.GetObject("AddNewToolStripMenuItem.Image");
            AddNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(226, 38);
            AddNewToolStripMenuItem.Text = "Add new Person";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(226, 38);
            EditToolStripMenuItem.Text = "Edit Info";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.Delete_User_32;
            deleteToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(226, 38);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(876, 532);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(lblCounter);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pbManagePeople);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageUsers";
            Text = "Manage Users";
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListAllUsers).EndInit();
            cmsUserMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbManagePeople;
        private Panel panel1;
        private DataGridView dgvListAllUsers;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colPersonId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colUserName;
        private Button btnClose;
        private Label lblCounter;
        private Label label2;
        private TextBox txtSearch;
        private Label label3;
        private ComboBox cbFilter;
        private ContextMenuStrip cmsUserMenu;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
    }
}