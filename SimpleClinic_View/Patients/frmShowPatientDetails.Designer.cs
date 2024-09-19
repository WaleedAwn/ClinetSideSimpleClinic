namespace SimpleClinic_View.Patients
{
    partial class frmShowPatientDetails
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
            ctrlPersonCard1 = new Controls.ctrlPersonCard();
            btnClose = new Button();
            btnEditInfo = new Button();
            lblAddEditPatient = new Label();
            lbPatientID = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(12, 177);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(927, 333);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(945, 483);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 53);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEditInfo
            // 
            btnEditInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditInfo.Location = new Point(785, 124);
            btnEditInfo.Name = "btnEditInfo";
            btnEditInfo.Size = new Size(154, 47);
            btnEditInfo.TabIndex = 13;
            btnEditInfo.Text = "Edit Info";
            btnEditInfo.UseVisualStyleBackColor = true;
            btnEditInfo.Click += btnEditInfo_Click;
            // 
            // lblAddEditPatient
            // 
            lblAddEditPatient.AutoSize = true;
            lblAddEditPatient.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEditPatient.ForeColor = Color.Red;
            lblAddEditPatient.Location = new Point(361, 9);
            lblAddEditPatient.Name = "lblAddEditPatient";
            lblAddEditPatient.Size = new Size(253, 45);
            lblAddEditPatient.TabIndex = 12;
            lblAddEditPatient.Text = "Patient Detailes";
            // 
            // lbPatientID
            // 
            lbPatientID.AutoSize = true;
            lbPatientID.Font = new Font("Microsoft Sans Serif", 12F);
            lbPatientID.Location = new Point(145, 109);
            lbPatientID.Name = "lbPatientID";
            lbPatientID.Size = new Size(75, 29);
            lbPatientID.TabIndex = 37;
            lbPatientID.Text = "[????]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 36;
            label1.Text = "Patient ID :";
            // 
            // frmShowPatientDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 548);
            Controls.Add(lbPatientID);
            Controls.Add(label1);
            Controls.Add(btnEditInfo);
            Controls.Add(lblAddEditPatient);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            Name = "frmShowPatientDetails";
            Text = "frmShowPatientDetails";
            Load += frmShowPatientDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard1;
        private Button btnClose;
        private Button btnEditInfo;
        private Label lblAddEditPatient;
        private Label lbPatientID;
        private Label label1;
    }
}