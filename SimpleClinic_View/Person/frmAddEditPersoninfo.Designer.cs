namespace SimpleClinic_View
{
    partial class frmAddEditPersoninfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPersoninfo));
            lblAddEditPersonTitel = new Label();
            lbPersonID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
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
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGender).BeginInit();
            SuspendLayout();
            // 
            // lblAddEditPersonTitel
            // 
            lblAddEditPersonTitel.AutoSize = true;
            lblAddEditPersonTitel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEditPersonTitel.ForeColor = Color.Red;
            lblAddEditPersonTitel.Location = new Point(322, 17);
            lblAddEditPersonTitel.Margin = new Padding(2, 0, 2, 0);
            lblAddEditPersonTitel.Name = "lblAddEditPersonTitel";
            lblAddEditPersonTitel.Size = new Size(229, 37);
            lblAddEditPersonTitel.TabIndex = 0;
            lblAddEditPersonTitel.Text = "Add New Person";
            // 
            // lbPersonID
            // 
            lbPersonID.AutoSize = true;
            lbPersonID.Font = new Font("Microsoft Sans Serif", 12F);
            lbPersonID.Location = new Point(118, 38);
            lbPersonID.Margin = new Padding(2, 0, 2, 0);
            lbPersonID.Name = "lbPersonID";
            lbPersonID.Size = new Size(68, 25);
            lbPersonID.TabIndex = 20;
            lbPersonID.Text = "[????]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(10, 188);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 19;
            label5.Text = "Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(15, 31);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 18;
            label4.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(10, 132);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 17;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(428, 138);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 16;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(16, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 15;
            label1.Text = "Person ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(10, 81);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 29;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(389, 94);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 28;
            label6.Text = "Date Of Birth:";
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
            panel1.Location = new Point(16, 92);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 241);
            panel1.TabIndex = 30;
            // 
            // pbDateOfBirth
            // 
            pbDateOfBirth.Image = (Image)resources.GetObject("pbDateOfBirth.Image");
            pbDateOfBirth.Location = new Point(524, 86);
            pbDateOfBirth.Margin = new Padding(2, 2, 2, 2);
            pbDateOfBirth.Name = "pbDateOfBirth";
            pbDateOfBirth.Size = new Size(32, 30);
            pbDateOfBirth.SizeMode = PictureBoxSizeMode.Zoom;
            pbDateOfBirth.TabIndex = 42;
            pbDateOfBirth.TabStop = false;
            // 
            // tbAdress
            // 
            tbAdress.BackColor = Color.White;
            tbAdress.Location = new Point(566, 142);
            tbAdress.Margin = new Padding(2, 2, 2, 2);
            tbAdress.Multiline = true;
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(187, 70);
            tbAdress.TabIndex = 41;
            // 
            // dtpDateOFBirth
            // 
            dtpDateOFBirth.Location = new Point(561, 90);
            dtpDateOFBirth.Margin = new Padding(2, 2, 2, 2);
            dtpDateOFBirth.Name = "dtpDateOFBirth";
            dtpDateOFBirth.Size = new Size(183, 27);
            dtpDateOFBirth.TabIndex = 40;
            // 
            // cbgender
            // 
            cbgender.FormattingEnabled = true;
            cbgender.Items.AddRange(new object[] { "Male", "Femal" });
            cbgender.Location = new Point(137, 191);
            cbgender.Margin = new Padding(2, 2, 2, 2);
            cbgender.Name = "cbgender";
            cbgender.Size = new Size(133, 28);
            cbgender.TabIndex = 39;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(97, 188);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Location = new Point(138, 138);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(186, 27);
            tbEmail.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 138);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.BackColor = Color.White;
            tbPhoneNumber.Location = new Point(137, 86);
            tbPhoneNumber.Margin = new Padding(2, 2, 2, 2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(186, 27);
            tbPhoneNumber.TabIndex = 35;
            // 
            // pbEmail
            // 
            pbEmail.Image = (Image)resources.GetObject("pbEmail.Image");
            pbEmail.Location = new Point(97, 86);
            pbEmail.Margin = new Padding(2, 2, 2, 2);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(32, 30);
            pbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmail.TabIndex = 33;
            pbEmail.TabStop = false;
            // 
            // pbAddress
            // 
            pbAddress.Image = (Image)resources.GetObject("pbAddress.Image");
            pbAddress.Location = new Point(524, 142);
            pbAddress.Margin = new Padding(2, 2, 2, 2);
            pbAddress.Name = "pbAddress";
            pbAddress.Size = new Size(32, 30);
            pbAddress.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddress.TabIndex = 32;
            pbAddress.TabStop = false;
            // 
            // pbGender
            // 
            pbGender.Image = (Image)resources.GetObject("pbGender.Image");
            pbGender.Location = new Point(97, 33);
            pbGender.Margin = new Padding(2, 2, 2, 2);
            pbGender.Name = "pbGender";
            pbGender.Size = new Size(32, 30);
            pbGender.SizeMode = PictureBoxSizeMode.Zoom;
            pbGender.TabIndex = 31;
            pbGender.TabStop = false;
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.Location = new Point(138, 35);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(186, 27);
            tbName.TabIndex = 30;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(634, 349);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 42);
            btnClose.TabIndex = 31;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(756, 349);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 42);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddEditPersoninfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(896, 450);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(lblAddEditPersonTitel);
            Controls.Add(lbPersonID);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmAddEditPersoninfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditPersoninfo";
            Load += frmAddEditPersoninfo_Load;
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

        private Label lblAddEditPersonTitel;
        private Label lbPersonID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private TextBox tbName;
        private TextBox tbPhoneNumber;
        private PictureBox pbEmail;
        private PictureBox pbAddress;
        private PictureBox pbGender;
        private TextBox tbEmail;
        private PictureBox pictureBox1;
        private ComboBox cbgender;
        private PictureBox pictureBox2;
        private DateTimePicker dtpDateOFBirth;
        private PictureBox pictureBox3;
        private TextBox tbAdress;
        private PictureBox pbDateOfBirth;
        private Button btnClose;
        private Button btnSave;
    }
}