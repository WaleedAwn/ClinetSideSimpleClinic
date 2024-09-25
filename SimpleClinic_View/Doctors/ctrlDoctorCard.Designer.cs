namespace SimpleClinic_View.Doctors
{
    partial class ctrlDoctorCard
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
            gbDoctorInfo = new GroupBox();
            lblSpecialization = new Label();
            lblDoctorId = new Label();
            label4 = new Label();
            label1 = new Label();
            gbDoctorInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(2, 3);
            ctrlPersonCard1.Margin = new Padding(2);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(678, 239);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbDoctorInfo
            // 
            gbDoctorInfo.Controls.Add(lblSpecialization);
            gbDoctorInfo.Controls.Add(lblDoctorId);
            gbDoctorInfo.Controls.Add(label4);
            gbDoctorInfo.Controls.Add(label1);
            gbDoctorInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDoctorInfo.Location = new Point(3, 237);
            gbDoctorInfo.Name = "gbDoctorInfo";
            gbDoctorInfo.Size = new Size(678, 87);
            gbDoctorInfo.TabIndex = 1;
            gbDoctorInfo.TabStop = false;
            gbDoctorInfo.Text = "Doctor Info";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Microsoft Sans Serif", 12F);
            lblSpecialization.ForeColor = Color.Red;
            lblSpecialization.Location = new Point(405, 42);
            lblSpecialization.Margin = new Padding(2, 0, 2, 0);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(68, 25);
            lblSpecialization.TabIndex = 18;
            lblSpecialization.Text = "[????]";
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.Font = new Font("Microsoft Sans Serif", 12F);
            lblDoctorId.Location = new Point(134, 42);
            lblDoctorId.Margin = new Padding(2, 0, 2, 0);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(68, 25);
            lblDoctorId.TabIndex = 17;
            lblDoctorId.Text = "[????]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(247, 42);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 16;
            label4.Text = "Specialization:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(21, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 15;
            label1.Text = "Doctor ID:";
            // 
            // ctrlDoctorCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gbDoctorInfo);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlDoctorCard";
            Size = new Size(689, 326);
            gbDoctorInfo.ResumeLayout(false);
            gbDoctorInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbDoctorInfo;
        private Label lblSpecialization;
        private Label lblDoctorId;
        private Label label4;
        private Label label1;
    }
}
