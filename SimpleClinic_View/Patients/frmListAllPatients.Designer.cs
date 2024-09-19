namespace SimpleClinic_View
{
    partial class frmListAllPatients
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
            btnClose = new Button();
            btnAddNewpatient = new PictureBox();
            lblCounter = new Label();
            label2 = new Label();
            dgvListAllPatients = new DataGridView();
            colPatientID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDateOFBirth = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colAdress = new DataGridViewTextBoxColumn();
            colPersonID = new DataGridViewTextBoxColumn();
            contextMenuStrip2 = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            doAppoitmentToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pbManagePeople = new PictureBox();
            contextMenuStrip3 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)btnAddNewpatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllPatients).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            contextMenuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1491, 762);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 53);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewpatient
            // 
            btnAddNewpatient.BackgroundImage = Properties.Resources.Add_Person_40;
            btnAddNewpatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewpatient.BorderStyle = BorderStyle.FixedSingle;
            btnAddNewpatient.Location = new Point(1530, 267);
            btnAddNewpatient.Name = "btnAddNewpatient";
            btnAddNewpatient.Size = new Size(100, 74);
            btnAddNewpatient.TabIndex = 14;
            btnAddNewpatient.TabStop = false;
            btnAddNewpatient.Click += btnAddNewpatient_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblCounter.Location = new Point(153, 321);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(19, 20);
            lblCounter.TabIndex = 13;
            lblCounter.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(62, 321);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 12;
            label2.Text = "# Records:";
            // 
            // dgvListAllPatients
            // 
            dgvListAllPatients.AllowUserToAddRows = false;
            dgvListAllPatients.AllowUserToDeleteRows = false;
            dgvListAllPatients.AllowUserToOrderColumns = true;
            dgvListAllPatients.BackgroundColor = Color.White;
            dgvListAllPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllPatients.Columns.AddRange(new DataGridViewColumn[] { colPatientID, colName, colPhone, colEmail, colDateOFBirth, colGender, colAdress, colPersonID });
            dgvListAllPatients.ContextMenuStrip = contextMenuStrip2;
            dgvListAllPatients.Location = new Point(52, 351);
            dgvListAllPatients.Name = "dgvListAllPatients";
            dgvListAllPatients.ReadOnly = true;
            dgvListAllPatients.RowHeadersWidth = 62;
            dgvListAllPatients.Size = new Size(1578, 405);
            dgvListAllPatients.TabIndex = 11;
            // 
            // colPatientID
            // 
            colPatientID.HeaderText = "Patient ID";
            colPatientID.MinimumWidth = 8;
            colPatientID.Name = "colPatientID";
            colPatientID.ReadOnly = true;
            colPatientID.Width = 150;
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
            // colPersonID
            // 
            colPersonID.HeaderText = "Person ID";
            colPersonID.MinimumWidth = 8;
            colPersonID.Name = "colPersonID";
            colPersonID.ReadOnly = true;
            colPersonID.Width = 150;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1, doAppoitmentToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(249, 197);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(248, 32);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = Properties.Resources.Edit_User_32;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(248, 32);
            AddNewToolStripMenuItem.Text = "Add new Patient";
            AddNewToolStripMenuItem.Click += AddNewToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = Properties.Resources.Delete_User_32;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(248, 32);
            EditToolStripMenuItem.Text = "Edit Info";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.Delete_User_32;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(248, 32);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // doAppoitmentToolStripMenuItem
            // 
            doAppoitmentToolStripMenuItem.Name = "doAppoitmentToolStripMenuItem";
            doAppoitmentToolStripMenuItem.Size = new Size(248, 32);
            doAppoitmentToolStripMenuItem.Text = "Do Appoitment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.Location = new Point(685, 202);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 10;
            label1.Text = "Manage Patients";
            // 
            // pbManagePeople
            // 
            pbManagePeople.BackColor = Color.Transparent;
            pbManagePeople.Image = Properties.Resources.People_400;
            pbManagePeople.Location = new Point(685, 22);
            pbManagePeople.Name = "pbManagePeople";
            pbManagePeople.Size = new Size(279, 162);
            pbManagePeople.SizeMode = PictureBoxSizeMode.Zoom;
            pbManagePeople.TabIndex = 9;
            pbManagePeople.TabStop = false;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(24, 24);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7 });
            contextMenuStrip3.Name = "contextMenuStrip1";
            contextMenuStrip3.Size = new Size(229, 228);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.Add_Person_40;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(228, 32);
            toolStripMenuItem1.Text = "Show Details";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.Edit_User_32;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(228, 32);
            toolStripMenuItem2.Text = "Add new Person";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = Properties.Resources.Delete_User_32;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(228, 32);
            toolStripMenuItem3.Text = "Edit Info";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = Properties.Resources.Delete_User_32;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(228, 32);
            toolStripMenuItem4.Text = "Delete";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(228, 32);
            toolStripMenuItem5.Text = "Do Appoitment";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(228, 32);
            toolStripMenuItem6.Text = "Add AS Patient";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(228, 32);
            toolStripMenuItem7.Text = "Add AS Doctor";
            // 
            // frmListAllPatients
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 917);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewpatient);
            Controls.Add(lblCounter);
            Controls.Add(label2);
            Controls.Add(dgvListAllPatients);
            Controls.Add(label1);
            Controls.Add(pbManagePeople);
            Name = "frmListAllPatients";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "frmListAllPatients";
            Load += frmListAllPatients_Load;
            ((System.ComponentModel.ISupportInitialize)btnAddNewpatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllPatients).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            contextMenuStrip3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private PictureBox btnAddNewpatient;
        private Label lblCounter;
        private Label label2;
        private DataGridView dgvListAllPatients;
        private Label label1;
        private PictureBox pbManagePeople;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem doAppoitmentToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private DataGridViewTextBoxColumn colPatientID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDateOFBirth;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colAdress;
        private DataGridViewTextBoxColumn colPersonID;
    }
}