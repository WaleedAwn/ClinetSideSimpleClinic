namespace SimpleClinic_View.MedicalRecords.FormsMedicalRecods
{
    partial class frmAddNewMedicalRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewMedicalRecords));
            panel1 = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            lblMedicalRecordID = new Label();
            txtAdditionalNotes = new RichTextBox();
            txtDiagnosis = new TextBox();
            txtVisitDescription = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 97);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 97);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Add Medical Records";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMedicalRecordID);
            panel2.Controls.Add(txtAdditionalNotes);
            panel2.Controls.Add(txtDiagnosis);
            panel2.Controls.Add(txtVisitDescription);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 353);
            panel2.TabIndex = 1;
            // 
            // lblMedicalRecordID
            // 
            lblMedicalRecordID.AutoSize = true;
            lblMedicalRecordID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicalRecordID.Location = new Point(208, 35);
            lblMedicalRecordID.Name = "lblMedicalRecordID";
            lblMedicalRecordID.Size = new Size(62, 28);
            lblMedicalRecordID.TabIndex = 54;
            lblMedicalRecordID.Text = "[????]";
            // 
            // txtAdditionalNotes
            // 
            txtAdditionalNotes.Location = new Point(263, 154);
            txtAdditionalNotes.Name = "txtAdditionalNotes";
            txtAdditionalNotes.Size = new Size(314, 120);
            txtAdditionalNotes.TabIndex = 53;
            txtAdditionalNotes.Text = "";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(263, 112);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(314, 34);
            txtDiagnosis.TabIndex = 52;
            // 
            // txtVisitDescription
            // 
            txtVisitDescription.Location = new Point(263, 70);
            txtVisitDescription.Multiline = true;
            txtVisitDescription.Name = "txtVisitDescription";
            txtVisitDescription.Size = new Size(314, 34);
            txtVisitDescription.TabIndex = 51;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(207, 148);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.edit_32;
            pictureBox1.Location = new Point(208, 70);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(207, 111);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label15.Location = new Point(11, 111);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(120, 25);
            label15.TabIndex = 47;
            label15.Text = "Diagnosis :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label16.Location = new Point(11, 75);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(187, 25);
            label16.TabIndex = 46;
            label16.Text = "Visit Describation:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label17.Location = new Point(11, 153);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(183, 25);
            label17.TabIndex = 45;
            label17.Text = "Additional Notes :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label18.Location = new Point(11, 38);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(190, 25);
            label18.TabIndex = 44;
            label18.Text = "Medical Reord ID :";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 47);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(btnClose);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(546, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 47);
            panel4.TabIndex = 34;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(128, 2);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 45);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(2, 2);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 45);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddNewMedicalRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAddNewMedicalRecords";
            Text = "frmAddNewMedicalRecords";
            Load += frmAddNewMedicalRecords_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblTitle;
        public PictureBox pictureBox3;
        public PictureBox pictureBox1;
        public PictureBox pictureBox4;
        public Label label15;
        public Label label16;
        public Label label17;
        public Label label18;
        private TextBox txtDiagnosis;
        private TextBox txtVisitDescription;
        private RichTextBox txtAdditionalNotes;
        private Panel panel4;
        private Button btnSave;
        private Button btnClose;
        private Label lblMedicalRecordID;
    }
}