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
            ctrlPersonCard1 = new Controls.ctrlPersonCard();
            ctrlDoctorCard1 = new Doctors.ctrlDoctorCard();
            groupBox1 = new GroupBox();
            lblAppointmentDate = new Label();
            lblAppointmentId = new Label();
            label4 = new Label();
            label1 = new Label();
            lblStatus = new Label();
            label3 = new Label();
            llShowMedicalRecord = new LinkLabel();
            llShowPayment = new LinkLabel();
            groupBox1.SuspendLayout();
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
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblAppointmentDate);
            groupBox1.Controls.Add(lblAppointmentId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(690, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 225);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment Info";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new Font("Microsoft Sans Serif", 12F);
            lblAppointmentDate.ForeColor = Color.Red;
            lblAppointmentDate.Location = new Point(95, 91);
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
            lblAppointmentId.Location = new Point(95, 40);
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
            label4.Location = new Point(25, 91);
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
            label1.Location = new Point(49, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 19;
            label1.Text = "ID:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 12F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(95, 142);
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
            label3.Location = new Point(8, 142);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 23;
            label3.Text = "Status:";
            // 
            // llShowMedicalRecord
            // 
            llShowMedicalRecord.AutoSize = true;
            llShowMedicalRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llShowMedicalRecord.Location = new Point(692, 238);
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
            llShowPayment.Location = new Point(905, 238);
            llShowPayment.Name = "llShowPayment";
            llShowPayment.Size = new Size(140, 28);
            llShowPayment.TabIndex = 26;
            llShowPayment.TabStop = true;
            llShowPayment.Text = "Show Payment";
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
            Size = new Size(1060, 619);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
