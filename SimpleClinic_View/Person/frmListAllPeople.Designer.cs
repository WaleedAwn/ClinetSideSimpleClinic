﻿namespace SimpleClinic_View
{
    partial class frmListAllPeople
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
            pbManagePeople = new PictureBox();
            label1 = new Label();
            dgvListAllPeople = new DataGridView();
            colPersonID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDateOFBirth = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colAdress = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            doAppoitmentToolStripMenuItem = new ToolStripMenuItem();
            addASPatientToolStripMenuItem = new ToolStripMenuItem();
            addASDoctorToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblCounter = new Label();
            btnAddNew = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddNew).BeginInit();
            SuspendLayout();
            // 
            // pbManagePeople
            // 
            pbManagePeople.BackColor = Color.Transparent;
            pbManagePeople.Image = Properties.Resources.People_400;
            pbManagePeople.Location = new Point(492, 10);
            pbManagePeople.Margin = new Padding(2, 2, 2, 2);
            pbManagePeople.Name = "pbManagePeople";
            pbManagePeople.Size = new Size(203, 130);
            pbManagePeople.SizeMode = PictureBoxSizeMode.Zoom;
            pbManagePeople.TabIndex = 0;
            pbManagePeople.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.Location = new Point(492, 142);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 1;
            label1.Text = "Manage People";
            // 
            // dgvListAllPeople
            // 
            dgvListAllPeople.AllowUserToAddRows = false;
            dgvListAllPeople.AllowUserToDeleteRows = false;
            dgvListAllPeople.AllowUserToOrderColumns = true;
            dgvListAllPeople.BackgroundColor = Color.White;
            dgvListAllPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllPeople.Columns.AddRange(new DataGridViewColumn[] { colPersonID, colName, colPhone, colEmail, colDateOFBirth, colGender, colAdress });
            dgvListAllPeople.ContextMenuStrip = contextMenuStrip1;
            dgvListAllPeople.Location = new Point(9, 209);
            dgvListAllPeople.Margin = new Padding(2, 2, 2, 2);
            dgvListAllPeople.Name = "dgvListAllPeople";
            dgvListAllPeople.ReadOnly = true;
            dgvListAllPeople.RowHeadersWidth = 62;
            dgvListAllPeople.Size = new Size(1148, 324);
            dgvListAllPeople.TabIndex = 2;
            // 
            // colPersonID
            // 
            colPersonID.HeaderText = "Person ID";
            colPersonID.MinimumWidth = 8;
            colPersonID.Name = "colPersonID";
            colPersonID.ReadOnly = true;
            colPersonID.Width = 150;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone Number";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 150;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 150;
            // 
            // colDateOFBirth
            // 
            colDateOFBirth.HeaderText = "Date OF Birth";
            colDateOFBirth.MinimumWidth = 8;
            colDateOFBirth.Name = "colDateOFBirth";
            colDateOFBirth.ReadOnly = true;
            colDateOFBirth.Width = 150;
            // 
            // colGender
            // 
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 150;
            // 
            // colAdress
            // 
            colAdress.HeaderText = "Addrees";
            colAdress.MinimumWidth = 8;
            colAdress.Name = "colAdress";
            colAdress.ReadOnly = true;
            colAdress.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1, doAppoitmentToolStripMenuItem, addASPatientToolStripMenuItem, addASDoctorToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(193, 214);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(192, 30);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = Properties.Resources.Edit_User_32;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(192, 30);
            AddNewToolStripMenuItem.Text = "Add new Person";
            AddNewToolStripMenuItem.Click += AddNewToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = Properties.Resources.Delete_User_32;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(192, 30);
            EditToolStripMenuItem.Text = "Edit Info";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.Delete_User_32;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(192, 30);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // doAppoitmentToolStripMenuItem
            // 
            doAppoitmentToolStripMenuItem.Name = "doAppoitmentToolStripMenuItem";
            doAppoitmentToolStripMenuItem.Size = new Size(192, 30);
            doAppoitmentToolStripMenuItem.Text = "Do Appoitment";
            // 
            // addASPatientToolStripMenuItem
            // 
            addASPatientToolStripMenuItem.Name = "addASPatientToolStripMenuItem";
            addASPatientToolStripMenuItem.Size = new Size(192, 30);
            addASPatientToolStripMenuItem.Text = "Add AS Patient";
            // 
            // addASDoctorToolStripMenuItem
            // 
            addASDoctorToolStripMenuItem.Name = "addASDoctorToolStripMenuItem";
            addASDoctorToolStripMenuItem.Size = new Size(192, 30);
            addASDoctorToolStripMenuItem.Text = "Add AS Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 185);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 4;
            label2.Text = "# Records:";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblCounter.Location = new Point(82, 185);
            lblCounter.Margin = new Padding(2, 0, 2, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(15, 16);
            lblCounter.TabIndex = 6;
            lblCounter.Text = "0";
            // 
            // btnAddNew
            // 
            btnAddNew.BackgroundImage = Properties.Resources.Add_Person_40;
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.BorderStyle = BorderStyle.FixedSingle;
            btnAddNew.Location = new Point(1084, 142);
            btnAddNew.Margin = new Padding(2, 2, 2, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(73, 60);
            btnAddNew.TabIndex = 7;
            btnAddNew.TabStop = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1055, 538);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 42);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmListAllPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 593);
            Controls.Add(btnClose);
            Controls.Add(btnAddNew);
            Controls.Add(lblCounter);
            Controls.Add(label2);
            Controls.Add(dgvListAllPeople);
            Controls.Add(label1);
            Controls.Add(pbManagePeople);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmListAllPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage All People";
            Load += frmListAllPeople_Load;
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAddNew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbManagePeople;
        private Label label1;
        private DataGridView dgvListAllPeople;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private DataGridViewTextBoxColumn colPersonID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDateOFBirth;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colAdress;
        private Label label2;
        private Label lblCounter;
        private PictureBox btnAddNew;
        private Button btnClose;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem doAppoitmentToolStripMenuItem;
        private ToolStripMenuItem addASPatientToolStripMenuItem;
        private ToolStripMenuItem addASDoctorToolStripMenuItem;
    }
}