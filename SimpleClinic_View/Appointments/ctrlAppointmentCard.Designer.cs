namespace SimpleClinic_View.Appointments
{
    partial class ctrlAppointmentCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAppointmentCard));
            ctrlPersonCard1 = new Controls.ctrlPersonCard();
            ctrlDoctorCard1 = new Doctors.ctrlDoctorCard();
            groupBox1 = new GroupBox();
            lblStatus = new Label();
            label3 = new Label();
            lblAppointmentDate = new Label();
            lblAppointmentId = new Label();
            label4 = new Label();
            label1 = new Label();
            llShowMedicalRecord = new LinkLabel();
            llShowPayment = new LinkLabel();
            lblIsPaid = new Label();
            label5 = new Label();
            lblIsTreated = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(2, 2);
            ctrlPersonCard1.Margin = new Padding(2);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(683, 237);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlDoctorCard1
            // 
            ctrlDoctorCard1.BackColor = Color.White;
            ctrlDoctorCard1.Location = new Point(5, 238);
            ctrlDoctorCard1.Name = "ctrlDoctorCard1";
            ctrlDoctorCard1.Size = new Size(681, 325);
            ctrlDoctorCard1.TabIndex = 1;
            ctrlDoctorCard1.Load += ctrlDoctorCard1_Load;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(lblIsTreated);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblIsPaid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblAppointmentDate);
            groupBox1.Controls.Add(lblAppointmentId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(690, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 274);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment Info";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 12F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(162, 140);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 25);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "[????]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 140);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 23;
            label3.Text = "Status:";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new Font("Microsoft Sans Serif", 12F);
            lblAppointmentDate.ForeColor = Color.Red;
            lblAppointmentDate.Location = new Point(162, 92);
            lblAppointmentDate.Margin = new Padding(2, 0, 2, 0);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(68, 25);
            lblAppointmentDate.TabIndex = 22;
            lblAppointmentDate.Text = "[????]";
            // 
            // lblAppointmentId
            // 
            lblAppointmentId.AutoSize = true;
            lblAppointmentId.Font = new Font("Microsoft Sans Serif", 12F);
            lblAppointmentId.Location = new Point(162, 44);
            lblAppointmentId.Margin = new Padding(2, 0, 2, 0);
            lblAppointmentId.Name = "lblAppointmentId";
            lblAppointmentId.Size = new Size(68, 25);
            lblAppointmentId.TabIndex = 21;
            lblAppointmentId.Text = "[????]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(51, 92);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 20;
            label4.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(74, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 19;
            label1.Text = "ID:";
            // 
            // llShowMedicalRecord
            // 
            llShowMedicalRecord.AutoSize = true;
            llShowMedicalRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llShowMedicalRecord.Location = new Point(692, 279);
            llShowMedicalRecord.Name = "llShowMedicalRecord";
            llShowMedicalRecord.Size = new Size(200, 28);
            llShowMedicalRecord.TabIndex = 25;
            llShowMedicalRecord.TabStop = true;
            llShowMedicalRecord.Text = "Show Medical Record";
            // 
            // llShowPayment
            // 
            llShowPayment.AutoSize = true;
            llShowPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llShowPayment.Location = new Point(905, 279);
            llShowPayment.Name = "llShowPayment";
            llShowPayment.Size = new Size(140, 28);
            llShowPayment.TabIndex = 26;
            llShowPayment.TabStop = true;
            llShowPayment.Text = "Show Payment";
            // 
            // lblIsPaid
            // 
            lblIsPaid.AutoSize = true;
            lblIsPaid.Font = new Font("Microsoft Sans Serif", 12F);
            lblIsPaid.ForeColor = Color.Black;
            lblIsPaid.Location = new Point(162, 188);
            lblIsPaid.Margin = new Padding(2, 0, 2, 0);
            lblIsPaid.Name = "lblIsPaid";
            lblIsPaid.Size = new Size(68, 25);
            lblIsPaid.TabIndex = 26;
            lblIsPaid.Text = "[????]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(30, 188);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 25;
            label5.Text = "Is Paid:";
            // 
            // lblIsTreated
            // 
            lblIsTreated.AutoSize = true;
            lblIsTreated.Font = new Font("Microsoft Sans Serif", 12F);
            lblIsTreated.ForeColor = Color.Black;
            lblIsTreated.Location = new Point(162, 237);
            lblIsTreated.Margin = new Padding(2, 0, 2, 0);
            lblIsTreated.Name = "lblIsTreated";
            lblIsTreated.Size = new Size(68, 25);
            lblIsTreated.TabIndex = 28;
            lblIsTreated.Text = "[????]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(2, 237);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 27;
            label6.Text = "Is Treated:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(121, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(121, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(122, 134);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(121, 230);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // ctrlAppointmentCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(llShowPayment);
            Controls.Add(llShowMedicalRecord);
            Controls.Add(groupBox1);
            Controls.Add(ctrlDoctorCard1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlAppointmentCard";
            Size = new Size(1060, 569);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard1;
        private Doctors.ctrlDoctorCard ctrlDoctorCard1;
        private GroupBox groupBox1;
        private Label lblStatus;
        private Label label3;
        private Label lblAppointmentDate;
        private Label lblAppointmentId;
        private Label label4;
        private Label label1;
        private LinkLabel llShowMedicalRecord;
        private LinkLabel llShowPayment;
        private Label lblIsTreated;
        private Label label6;
        private Label lblIsPaid;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}
