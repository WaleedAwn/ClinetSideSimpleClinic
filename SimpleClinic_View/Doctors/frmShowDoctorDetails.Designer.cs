namespace SimpleClinic_View.Doctors
{
    partial class frmShowDoctorDetails
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
            lbDoctoriD = new Label();
            label1 = new Label();
            btnEditInfo = new Button();
            lblAddEditDoctor = new Label();
            ctrlPersonCard1 = new Controls.ctrlPersonCard();
            btnClose = new Button();
            lbSpecialization = new Label();
            label = new Label();
            SuspendLayout();
            // 
            // lbDoctoriD
            // 
            lbDoctoriD.AutoSize = true;
            lbDoctoriD.Font = new Font("Microsoft Sans Serif", 12F);
            lbDoctoriD.Location = new Point(167, 135);
            lbDoctoriD.Name = "lbDoctoriD";
            lbDoctoriD.Size = new Size(75, 29);
            lbDoctoriD.TabIndex = 41;
            lbDoctoriD.Text = "[????]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(34, 135);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 40;
            label1.Text = "Doctor ID :";
            // 
            // btnEditInfo
            // 
            btnEditInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditInfo.Location = new Point(829, 163);
            btnEditInfo.Name = "btnEditInfo";
            btnEditInfo.Size = new Size(154, 47);
            btnEditInfo.TabIndex = 39;
            btnEditInfo.Text = "Edit Info";
            btnEditInfo.UseVisualStyleBackColor = true;
            // 
            // lblAddEditDoctor
            // 
            lblAddEditDoctor.AutoSize = true;
            lblAddEditDoctor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEditDoctor.ForeColor = Color.Red;
            lblAddEditDoctor.Location = new Point(410, 32);
            lblAddEditDoctor.Name = "lblAddEditDoctor";
            lblAddEditDoctor.Size = new Size(252, 45);
            lblAddEditDoctor.TabIndex = 38;
            lblAddEditDoctor.Text = "Doctor Detailes";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(34, 215);
            ctrlPersonCard1.Margin = new Padding(3, 2, 3, 2);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(940, 336);
            ctrlPersonCard1.TabIndex = 42;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1025, 562);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 53);
            btnClose.TabIndex = 43;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbSpecialization
            // 
            lbSpecialization.AutoSize = true;
            lbSpecialization.Font = new Font("Microsoft Sans Serif", 12F);
            lbSpecialization.Location = new Point(761, 288);
            lbSpecialization.Name = "lbSpecialization";
            lbSpecialization.Size = new Size(75, 29);
            lbSpecialization.TabIndex = 45;
            lbSpecialization.Text = "[????]";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label.Location = new Point(561, 288);
            label.Name = "label";
            label.Size = new Size(191, 29);
            label.TabIndex = 44;
            label.Text = "Specialization :";
            // 
            // frmShowDoctorDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 651);
            Controls.Add(lbSpecialization);
            Controls.Add(label);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(lbDoctoriD);
            Controls.Add(label1);
            Controls.Add(btnEditInfo);
            Controls.Add(lblAddEditDoctor);
            Name = "frmShowDoctorDetails";
            Text = "frmShowDoctorDetails";
            Load += frmShowDoctorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDoctoriD;
        private Label label1;
        private Button btnEditInfo;
        private Label lblAddEditDoctor;
        private Controls.ctrlPersonCard ctrlPersonCard1;
        private Button btnClose;
        private Label lbSpecialization;
        private Label label;
    }
}