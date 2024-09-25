namespace SimpleClinic_View.Doctors
{
    partial class frmListAllDoctors
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
            btnAddNewDoctor = new PictureBox();
            lblCounter = new Label();
            label2 = new Label();
            dgvListAllDoctors = new DataGridView();
            colPatientID = new DataGridViewTextBoxColumn();
            colSpesialization = new DataGridViewTextBoxColumn();
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
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)btnAddNewDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllDoctors).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            SuspendLayout();
            // 
            // btnAddNewDoctor
            // 
            btnAddNewDoctor.BackgroundImage = Properties.Resources.Add_Person_40;
            btnAddNewDoctor.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewDoctor.BorderStyle = BorderStyle.FixedSingle;
            btnAddNewDoctor.Location = new Point(1484, 257);
            btnAddNewDoctor.Name = "btnAddNewDoctor";
            btnAddNewDoctor.Size = new Size(100, 74);
            btnAddNewDoctor.TabIndex = 20;
            btnAddNewDoctor.TabStop = false;
            btnAddNewDoctor.Click += btnAddNewDoctor_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblCounter.Location = new Point(108, 301);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(19, 20);
            lblCounter.TabIndex = 19;
            lblCounter.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 301);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 18;
            label2.Text = "# Records:";
            // 
            // dgvListAllDoctors
            // 
            dgvListAllDoctors.AllowUserToAddRows = false;
            dgvListAllDoctors.AllowUserToDeleteRows = false;
            dgvListAllDoctors.AllowUserToOrderColumns = true;
            dgvListAllDoctors.BackgroundColor = Color.White;
            dgvListAllDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllDoctors.Columns.AddRange(new DataGridViewColumn[] { colPatientID, colSpesialization, colName, colPhone, colEmail, colDateOFBirth, colGender, colAdress, colPersonID });
            dgvListAllDoctors.ContextMenuStrip = contextMenuStrip2;
            dgvListAllDoctors.Location = new Point(6, 341);
            dgvListAllDoctors.Name = "dgvListAllDoctors";
            dgvListAllDoctors.ReadOnly = true;
            dgvListAllDoctors.RowHeadersWidth = 62;
            dgvListAllDoctors.Size = new Size(1578, 405);
            dgvListAllDoctors.TabIndex = 17;
            // 
            // colPatientID
            // 
            colPatientID.HeaderText = "Patient ID";
            colPatientID.MinimumWidth = 8;
            colPatientID.Name = "colPatientID";
            colPatientID.ReadOnly = true;
            colPatientID.Width = 150;
            // 
            // colSpesialization
            // 
            colSpesialization.HeaderText = "Spesalization";
            colSpesialization.MinimumWidth = 8;
            colSpesialization.Name = "colSpesialization";
            colSpesialization.ReadOnly = true;
            colSpesialization.Width = 150;
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
            contextMenuStrip2.Size = new Size(229, 164);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(228, 32);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = Properties.Resources.Edit_User_32;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(228, 32);
            AddNewToolStripMenuItem.Text = "Add new Doctor";
            AddNewToolStripMenuItem.Click += AddNewToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = Properties.Resources.Delete_User_32;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(228, 32);
            EditToolStripMenuItem.Text = "Edit Info";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.Delete_User_32;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(228, 32);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // doAppoitmentToolStripMenuItem
            // 
            doAppoitmentToolStripMenuItem.Name = "doAppoitmentToolStripMenuItem";
            doAppoitmentToolStripMenuItem.Size = new Size(228, 32);
            doAppoitmentToolStripMenuItem.Text = "Do Appoitment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.Location = new Point(639, 192);
            label1.Name = "label1";
            label1.Size = new Size(281, 40);
            label1.TabIndex = 16;
            label1.Text = "Manage Doctors";
            // 
            // pbManagePeople
            // 
            pbManagePeople.BackColor = Color.Transparent;
            pbManagePeople.Image = Properties.Resources.People_400;
            pbManagePeople.Location = new Point(639, 12);
            pbManagePeople.Name = "pbManagePeople";
            pbManagePeople.Size = new Size(279, 162);
            pbManagePeople.SizeMode = PictureBoxSizeMode.Zoom;
            pbManagePeople.TabIndex = 15;
            pbManagePeople.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1445, 766);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 53);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmListAllDoctors
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 831);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewDoctor);
            Controls.Add(lblCounter);
            Controls.Add(label2);
            Controls.Add(dgvListAllDoctors);
            Controls.Add(label1);
            Controls.Add(pbManagePeople);
            Name = "frmListAllDoctors";
            Text = "frmListAllDoctors";
            Load += frmListAllDoctors_Load;
            ((System.ComponentModel.ISupportInitialize)btnAddNewDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllDoctors).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnAddNewDoctor;
        private Label lblCounter;
        private Label label2;
        private DataGridView dgvListAllDoctors;
        private Label label1;
        private PictureBox pbManagePeople;
        private DataGridViewTextBoxColumn colPatientID;
        private DataGridViewTextBoxColumn colSpesialization;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDateOFBirth;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colAdress;
        private DataGridViewTextBoxColumn colPersonID;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem doAppoitmentToolStripMenuItem;
        private Button btnClose;
    }
}