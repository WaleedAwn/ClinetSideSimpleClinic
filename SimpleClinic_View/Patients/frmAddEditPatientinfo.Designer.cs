namespace SimpleClinic_View
{
    partial class frmAddEditPatientinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPatientinfo));
            btnSave = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            pbDateOfBirth = new PictureBox();
            tbAdress = new TextBox();
            dtpDateOFBirth = new DateTimePicker();
            cbgender = new ComboBox();
            pictureBox2 = new PictureBox();
            tbEmail = new TextBox();
            pictureBox1 = new PictureBox();
            tbPhoneNumber = new TextBox();
            pbEmail = new PictureBox();
            pbAddress = new PictureBox();
            pbGender = new PictureBox();
            tbName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAddEditPatientTitel = new Label();
            lbPatientID = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(1058, 436);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 53);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(891, 436);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 53);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbDateOfBirth);
            panel1.Controls.Add(tbAdress);
            panel1.Controls.Add(dtpDateOFBirth);
            panel1.Controls.Add(cbgender);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbPhoneNumber);
            panel1.Controls.Add(pbEmail);
            panel1.Controls.Add(pbAddress);
            panel1.Controls.Add(pbGender);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(41, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 301);
            panel1.TabIndex = 36;
            // 
            // pbDateOfBirth
            // 
            pbDateOfBirth.Image = (Image)resources.GetObject("pbDateOfBirth.Image");
            pbDateOfBirth.Location = new Point(721, 108);
            pbDateOfBirth.Name = "pbDateOfBirth";
            pbDateOfBirth.Size = new Size(44, 38);
            pbDateOfBirth.SizeMode = PictureBoxSizeMode.Zoom;
            pbDateOfBirth.TabIndex = 42;
            pbDateOfBirth.TabStop = false;
            // 
            // tbAdress
            // 
            tbAdress.BackColor = Color.White;
            tbAdress.Location = new Point(778, 177);
            tbAdress.Multiline = true;
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(255, 87);
            tbAdress.TabIndex = 41;
            // 
            // dtpDateOFBirth
            // 
            dtpDateOFBirth.Location = new Point(771, 113);
            dtpDateOFBirth.Name = "dtpDateOFBirth";
            dtpDateOFBirth.Size = new Size(250, 33);
            dtpDateOFBirth.TabIndex = 40;
            // 
            // cbgender
            // 
            cbgender.FormattingEnabled = true;
            cbgender.Items.AddRange(new object[] { "Male", "Femal" });
            cbgender.Location = new Point(189, 239);
            cbgender.Name = "cbgender";
            cbgender.Size = new Size(182, 33);
            cbgender.TabIndex = 39;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(134, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Location = new Point(190, 172);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(254, 33);
            tbEmail.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.BackColor = Color.White;
            tbPhoneNumber.Location = new Point(189, 108);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(254, 33);
            tbPhoneNumber.TabIndex = 35;
            // 
            // pbEmail
            // 
            pbEmail.Image = (Image)resources.GetObject("pbEmail.Image");
            pbEmail.Location = new Point(133, 108);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(44, 38);
            pbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmail.TabIndex = 33;
            pbEmail.TabStop = false;
            // 
            // pbAddress
            // 
            pbAddress.Image = (Image)resources.GetObject("pbAddress.Image");
            pbAddress.Location = new Point(721, 177);
            pbAddress.Name = "pbAddress";
            pbAddress.Size = new Size(44, 38);
            pbAddress.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddress.TabIndex = 32;
            pbAddress.TabStop = false;
            // 
            // pbGender
            // 
            pbGender.Image = (Image)resources.GetObject("pbGender.Image");
            pbGender.Location = new Point(133, 41);
            pbGender.Name = "pbGender";
            pbGender.Size = new Size(44, 38);
            pbGender.SizeMode = PictureBoxSizeMode.Zoom;
            pbGender.TabIndex = 31;
            pbGender.TabStop = false;
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.Location = new Point(190, 44);
            tbName.Name = "tbName";
            tbName.Size = new Size(254, 33);
            tbName.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(535, 117);
            label6.Name = "label6";
            label6.Size = new Size(169, 29);
            label6.TabIndex = 28;
            label6.Text = "Date Of Birth:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(14, 101);
            label7.Name = "label7";
            label7.Size = new Size(95, 29);
            label7.TabIndex = 29;
            label7.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(588, 172);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 16;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(14, 165);
            label3.Name = "label3";
            label3.Size = new Size(86, 29);
            label3.TabIndex = 17;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(20, 39);
            label4.Name = "label4";
            label4.Size = new Size(89, 29);
            label4.TabIndex = 18;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(14, 235);
            label5.Name = "label5";
            label5.Size = new Size(114, 29);
            label5.TabIndex = 19;
            label5.Text = "Gender :";
            // 
            // lblAddEditPatientTitel
            // 
            lblAddEditPatientTitel.AutoSize = true;
            lblAddEditPatientTitel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEditPatientTitel.ForeColor = Color.Red;
            lblAddEditPatientTitel.Location = new Point(462, 21);
            lblAddEditPatientTitel.Name = "lblAddEditPatientTitel";
            lblAddEditPatientTitel.Size = new Size(274, 45);
            lblAddEditPatientTitel.TabIndex = 33;
            lblAddEditPatientTitel.Text = "Add New Patient";
            // 
            // lbPatientID
            // 
            lbPatientID.AutoSize = true;
            lbPatientID.Font = new Font("Microsoft Sans Serif", 12F);
            lbPatientID.Location = new Point(174, 47);
            lbPatientID.Name = "lbPatientID";
            lbPatientID.Size = new Size(75, 29);
            lbPatientID.TabIndex = 35;
            lbPatientID.Text = "[????]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(41, 47);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 34;
            label1.Text = "Patient ID :";
            // 
            // frmAddEditPatientinfo
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 532);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(lblAddEditPatientTitel);
            Controls.Add(lbPatientID);
            Controls.Add(label1);
            Name = "frmAddEditPatientinfo";
            Text = "frmAddEditPatientinfo";
            Load += frmAddEditPatientinfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private Panel panel1;
        private PictureBox pbDateOfBirth;
        private TextBox tbAdress;
        private DateTimePicker dtpDateOFBirth;
        private ComboBox cbgender;
        private PictureBox pictureBox2;
        private TextBox tbEmail;
        private PictureBox pictureBox1;
        private TextBox tbPhoneNumber;
        private PictureBox pbEmail;
        private PictureBox pbAddress;
        private PictureBox pbGender;
        private TextBox tbName;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblAddEditPatientTitel;
        private Label lbPatientID;
        private Label label1;
    }
}