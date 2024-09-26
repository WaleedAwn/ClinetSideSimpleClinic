namespace SimpleClinic_View.Preception.FormsPreception
{
    partial class frmAddEditPreciption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPreciption));
            panel2 = new Panel();
            lblTitle = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            txtSpecialInstructions = new Label();
            dtpEneDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtFrequency = new TextBox();
            txtMedicalName = new TextBox();
            txtDosage = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblPreceptionID = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            lblMedicalRecordID = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 78);
            panel2.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 78);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Add New Preception";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 402);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 48);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(btnClose);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(551, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(249, 48);
            panel4.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(121, 1);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 45);
            btnSave.TabIndex = 37;
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
            btnClose.Location = new Point(2, 3);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 45);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMedicalRecordID);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtSpecialInstructions);
            panel1.Controls.Add(dtpEneDate);
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtFrequency);
            panel1.Controls.Add(txtMedicalName);
            panel1.Controls.Add(txtDosage);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblPreceptionID);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 324);
            panel1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(271, 275);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 34);
            textBox3.TabIndex = 105;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(217, 278);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 104;
            pictureBox2.TabStop = false;
            // 
            // txtSpecialInstructions
            // 
            txtSpecialInstructions.AutoSize = true;
            txtSpecialInstructions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtSpecialInstructions.Location = new Point(11, 278);
            txtSpecialInstructions.Margin = new Padding(2, 0, 2, 0);
            txtSpecialInstructions.Name = "txtSpecialInstructions";
            txtSpecialInstructions.Size = new Size(0, 25);
            txtSpecialInstructions.TabIndex = 103;
            // 
            // dtpEneDate
            // 
            dtpEneDate.Location = new Point(271, 241);
            dtpEneDate.Name = "dtpEneDate";
            dtpEneDate.Size = new Size(230, 27);
            dtpEneDate.TabIndex = 102;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(271, 199);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(230, 27);
            dtpStartDate.TabIndex = 101;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Calendar_321;
            pictureBox6.Location = new Point(217, 241);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 100;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Calendar_32;
            pictureBox5.Location = new Point(218, 199);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 100;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(218, 161);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 100;
            pictureBox7.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 241);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 96;
            label5.Text = "EndDate :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(11, 204);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 95;
            label6.Text = "StartDate :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.Location = new Point(11, 168);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 94;
            label8.Text = "Frequency :";
            // 
            // txtFrequency
            // 
            txtFrequency.Location = new Point(271, 159);
            txtFrequency.Multiline = true;
            txtFrequency.Name = "txtFrequency";
            txtFrequency.Size = new Size(230, 34);
            txtFrequency.TabIndex = 93;
            // 
            // txtMedicalName
            // 
            txtMedicalName.Location = new Point(271, 79);
            txtMedicalName.Multiline = true;
            txtMedicalName.Name = "txtMedicalName";
            txtMedicalName.Size = new Size(230, 34);
            txtMedicalName.TabIndex = 92;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(271, 117);
            txtDosage.Multiline = true;
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(230, 34);
            txtDosage.TabIndex = 91;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(217, 121);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 76;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(218, 45);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(218, 86);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 75;
            pictureBox4.TabStop = false;
            // 
            // lblPreceptionID
            // 
            lblPreceptionID.AutoSize = true;
            lblPreceptionID.Font = new Font("Microsoft Sans Serif", 12F);
            lblPreceptionID.Location = new Point(182, 8);
            lblPreceptionID.Margin = new Padding(2, 0, 2, 0);
            lblPreceptionID.Name = "lblPreceptionID";
            lblPreceptionID.Size = new Size(68, 25);
            lblPreceptionID.TabIndex = 73;
            lblPreceptionID.Text = "[????]";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label15.Location = new Point(11, 86);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(192, 25);
            label15.TabIndex = 71;
            label15.Text = "Medication Name :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label16.Location = new Point(11, 43);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(201, 25);
            label16.TabIndex = 70;
            label16.Text = "Medical Record ID :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label17.Location = new Point(11, 126);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(99, 25);
            label17.TabIndex = 69;
            label17.Text = "Dosage :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label18.Location = new Point(11, 8);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(155, 25);
            label18.TabIndex = 68;
            label18.Text = "Perception ID :";
            // 
            // lblMedicalRecordID
            // 
            lblMedicalRecordID.Location = new Point(271, 40);
            lblMedicalRecordID.Multiline = true;
            lblMedicalRecordID.Name = "lblMedicalRecordID";
            lblMedicalRecordID.Size = new Size(230, 34);
            lblMedicalRecordID.TabIndex = 106;
            // 
            // frmAddEditPreciption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "frmAddEditPreciption";
            Text = "frmAddEditPreciption";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private TextBox txtMedicalName;
        private TextBox txtDosage;
        public PictureBox pictureBox3;
        public PictureBox pictureBox1;
        public PictureBox pictureBox4;
        public Label lblPreceptionID;
        public Label label15;
        public Label label16;
        public Label label17;
        public Label label18;
        public PictureBox pictureBox7;
        public Label label5;
        public Label label6;
        public Label label8;
        private DateTimePicker dtpEneDate;
        private DateTimePicker dtpStartDate;
        public PictureBox pictureBox6;
        public PictureBox pictureBox5;
        private TextBox txtFrequency;
        private TextBox textBox3;
        public PictureBox pictureBox2;
        public Label txtSpecialInstructions;
        private Label lblTitle;
        private Button btnSave;
        private Button btnClose;
        private TextBox lblMedicalRecordID;
    }
}