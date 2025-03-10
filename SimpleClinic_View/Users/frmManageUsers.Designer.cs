﻿namespace SimpleClinic_View.Users
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
            cmsUserMenu = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            lblCounter = new Label();
            label2 = new Label();
            txtFilter = new TextBox();
            label3 = new Label();
            cbFilterBy = new ComboBox();
            btnAddNew = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAllUsers).BeginInit();
            cmsUserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddNew).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(398, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 41);
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
            dgvListAllUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListAllUsers.BackgroundColor = Color.White;
            dgvListAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllUsers.ContextMenuStrip = cmsUserMenu;
            dgvListAllUsers.Dock = DockStyle.Fill;
            dgvListAllUsers.Location = new Point(0, 0);
            dgvListAllUsers.Name = "dgvListAllUsers";
            dgvListAllUsers.ReadOnly = true;
            dgvListAllUsers.RowHeadersWidth = 51;
            dgvListAllUsers.Size = new Size(868, 264);
            dgvListAllUsers.TabIndex = 0;
            // 
            // cmsUserMenu
            // 
            cmsUserMenu.ImageScalingSize = new Size(24, 24);
            cmsUserMenu.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1, changePasswordToolStripMenuItem });
            cmsUserMenu.Name = "contextMenuStrip1";
            cmsUserMenu.Size = new Size(210, 194);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(209, 38);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = (Image)resources.GetObject("AddNewToolStripMenuItem.Image");
            AddNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(209, 38);
            AddNewToolStripMenuItem.Text = "Add new User";
            AddNewToolStripMenuItem.Click += AddNewToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(209, 38);
            EditToolStripMenuItem.Text = "Edit User";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.Delete_User_32;
            deleteToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(209, 38);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = (Image)resources.GetObject("changePasswordToolStripMenuItem.Image");
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(209, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
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
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 12F);
            txtFilter.Location = new Point(266, 178);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(211, 34);
            txtFilter.TabIndex = 12;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 13;
            label3.Text = "Filter:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Segoe UI", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "User Id", "Person Id", "Full Name", "User Name" });
            cbFilterBy.Location = new Point(78, 176);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(179, 36);
            cbFilterBy.TabIndex = 14;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // btnAddNew
            // 
            btnAddNew.BackgroundImage = Properties.Resources.Add_Person_40;
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.BorderStyle = BorderStyle.FixedSingle;
            btnAddNew.Location = new Point(796, 158);
            btnAddNew.Margin = new Padding(2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(73, 60);
            btnAddNew.TabIndex = 15;
            btnAddNew.TabStop = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(876, 532);
            Controls.Add(btnAddNew);
            Controls.Add(cbFilterBy);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(lblCounter);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pbManagePeople);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListAllUsers).EndInit();
            cmsUserMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAddNew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbManagePeople;
        private Panel panel1;
        private DataGridView dgvListAllUsers;
        private Button btnClose;
        private Label lblCounter;
        private Label label2;
        private TextBox txtFilter;
        private Label label3;
        private ComboBox cbFilterBy;
        private ContextMenuStrip cmsUserMenu;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private PictureBox btnAddNew;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}