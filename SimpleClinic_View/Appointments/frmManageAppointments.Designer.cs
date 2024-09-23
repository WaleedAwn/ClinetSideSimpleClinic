namespace SimpleClinic_View.Appointments
{
    partial class frmManageAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAppointments));
            btnAddNew = new PictureBox();
            label3 = new Label();
            txtFilter = new TextBox();
            lblCounter = new Label();
            label2 = new Label();
            btnClose = new Button();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            cbFilterBy = new ComboBox();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            cmsAppointmentMenu = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            cancelAppointmentToolStripMenuItem = new ToolStripMenuItem();
            completeProceduresToolStripMenuItem = new ToolStripMenuItem();
            tsmiPayment = new ToolStripMenuItem();
            tsmiVisitDoctor = new ToolStripMenuItem();
            dgvListAllAppointments = new DataGridView();
            panel1 = new Panel();
            pbManagePeople = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnAddNew).BeginInit();
            cmsAppointmentMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAllAppointments).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).BeginInit();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.BackgroundImage = (Image)resources.GetObject("btnAddNew.BackgroundImage");
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.BorderStyle = BorderStyle.FixedSingle;
            btnAddNew.Location = new Point(1252, 162);
            btnAddNew.Margin = new Padding(2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(73, 60);
            btnAddNew.TabIndex = 25;
            btnAddNew.TabStop = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 187);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 23;
            label3.Text = "Filter By:";
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 12F);
            txtFilter.Location = new Point(326, 179);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(211, 34);
            txtFilter.TabIndex = 22;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCounter.Location = new Point(125, 533);
            lblCounter.Margin = new Padding(2, 0, 2, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(24, 28);
            lblCounter.TabIndex = 21;
            lblCounter.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 533);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 20;
            label2.Text = "# Records:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1182, 531);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 40);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.Delete_User_32;
            deleteToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(245, 38);
            deleteToolStripMenuItem1.Text = "Delete Appointment";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(245, 38);
            EditToolStripMenuItem.Text = "Edit Appointment";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Segoe UI", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Id", "Patient Id", "Patient Name", "Dr.Id", "Dr.Name", "Status", "Medical Record", "Payment" });
            cbFilterBy.Location = new Point(110, 179);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(210, 36);
            cbFilterBy.TabIndex = 24;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = (Image)resources.GetObject("AddNewToolStripMenuItem.Image");
            AddNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(245, 38);
            AddNewToolStripMenuItem.Text = "Add new Appointment";
            AddNewToolStripMenuItem.Click += AddNewToolStripMenuItem_Click;
            // 
            // cmsAppointmentMenu
            // 
            cmsAppointmentMenu.ImageScalingSize = new Size(24, 24);
            cmsAppointmentMenu.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1, cancelAppointmentToolStripMenuItem, completeProceduresToolStripMenuItem });
            cmsAppointmentMenu.Name = "contextMenuStrip1";
            cmsAppointmentMenu.Size = new Size(246, 232);
            cmsAppointmentMenu.Opening += cmsAppointmentMenu_Opening;
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(245, 38);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            cancelAppointmentToolStripMenuItem.Image = (Image)resources.GetObject("cancelAppointmentToolStripMenuItem.Image");
            cancelAppointmentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            cancelAppointmentToolStripMenuItem.Size = new Size(245, 38);
            cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            cancelAppointmentToolStripMenuItem.Click += cancelAppointmentToolStripMenuItem_Click;
            // 
            // completeProceduresToolStripMenuItem
            // 
            completeProceduresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiPayment, tsmiVisitDoctor });
            completeProceduresToolStripMenuItem.Image = (Image)resources.GetObject("completeProceduresToolStripMenuItem.Image");
            completeProceduresToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeProceduresToolStripMenuItem.Name = "completeProceduresToolStripMenuItem";
            completeProceduresToolStripMenuItem.Size = new Size(245, 38);
            completeProceduresToolStripMenuItem.Text = "Complete Procedures";
            // 
            // tsmiPayment
            // 
            tsmiPayment.Image = (Image)resources.GetObject("tsmiPayment.Image");
            tsmiPayment.ImageScaling = ToolStripItemImageScaling.None;
            tsmiPayment.Name = "tsmiPayment";
            tsmiPayment.Size = new Size(236, 38);
            tsmiPayment.Text = "Payment";
            // 
            // tsmiVisitDoctor
            // 
            tsmiVisitDoctor.Image = (Image)resources.GetObject("tsmiVisitDoctor.Image");
            tsmiVisitDoctor.ImageScaling = ToolStripItemImageScaling.None;
            tsmiVisitDoctor.Name = "tsmiVisitDoctor";
            tsmiVisitDoctor.Size = new Size(236, 38);
            tsmiVisitDoctor.Text = "Visit Doctor";
            // 
            // dgvListAllAppointments
            // 
            dgvListAllAppointments.AllowUserToAddRows = false;
            dgvListAllAppointments.AllowUserToDeleteRows = false;
            dgvListAllAppointments.AllowUserToOrderColumns = true;
            dgvListAllAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListAllAppointments.BackgroundColor = Color.White;
            dgvListAllAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllAppointments.ContextMenuStrip = cmsAppointmentMenu;
            dgvListAllAppointments.Dock = DockStyle.Fill;
            dgvListAllAppointments.Location = new Point(0, 0);
            dgvListAllAppointments.Name = "dgvListAllAppointments";
            dgvListAllAppointments.ReadOnly = true;
            dgvListAllAppointments.RowHeadersWidth = 51;
            dgvListAllAppointments.Size = new Size(1314, 301);
            dgvListAllAppointments.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(dgvListAllAppointments);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 301);
            panel1.TabIndex = 18;
            // 
            // pbManagePeople
            // 
            pbManagePeople.BackColor = Color.Transparent;
            pbManagePeople.Image = (Image)resources.GetObject("pbManagePeople.Image");
            pbManagePeople.Location = new Point(606, 0);
            pbManagePeople.Margin = new Padding(2);
            pbManagePeople.Name = "pbManagePeople";
            pbManagePeople.Size = new Size(277, 120);
            pbManagePeople.SizeMode = PictureBoxSizeMode.Zoom;
            pbManagePeople.TabIndex = 16;
            pbManagePeople.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(579, 122);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 41);
            label1.TabIndex = 17;
            label1.Text = "Manage Appointments";
            // 
            // frmManageAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1332, 583);
            Controls.Add(btnAddNew);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(lblCounter);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(cbFilterBy);
            Controls.Add(panel1);
            Controls.Add(pbManagePeople);
            Controls.Add(label1);
            Name = "frmManageAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageAppointments";
            Load += frmManageAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)btnAddNew).EndInit();
            cmsAppointmentMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListAllAppointments).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbManagePeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnAddNew;
        private Label label3;
        private TextBox txtFilter;
        private Label lblCounter;
        private Label label2;
        private Button btnClose;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ComboBox cbFilterBy;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ContextMenuStrip cmsAppointmentMenu;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private DataGridView dgvListAllAppointments;
        private Panel panel1;
        private PictureBox pbManagePeople;
        private Label label1;
        private ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private ToolStripMenuItem completeProceduresToolStripMenuItem;
        private ToolStripMenuItem tsmiPayment;
        private ToolStripMenuItem tsmiVisitDoctor;
    }
}