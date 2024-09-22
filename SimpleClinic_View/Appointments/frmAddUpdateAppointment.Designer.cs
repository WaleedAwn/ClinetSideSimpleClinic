namespace SimpleClinic_View.Appointments
{
    partial class frmAddUpdateAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateAppointment));
            tcAppointments = new TabControl();
            tpPatientInfo = new TabPage();
            btnNext = new Button();
            ctrlPersonCardWithFilter1 = new Controls.ctrlPersonCardWithFilter();
            tpAppointmentInfo = new TabPage();
            label4 = new Label();
            lblAppointmentId = new Label();
            label2 = new Label();
            cbDoctors = new ComboBox();
            label1 = new Label();
            dtpAppointmentDate = new DateTimePicker();
            btnSave = new Button();
            btnClose = new Button();
            lblMode = new Label();
            tcAppointments.SuspendLayout();
            tpPatientInfo.SuspendLayout();
            tpAppointmentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tcAppointments
            // 
            tcAppointments.Controls.Add(tpPatientInfo);
            tcAppointments.Controls.Add(tpAppointmentInfo);
            tcAppointments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tcAppointments.Location = new Point(12, 72);
            tcAppointments.Name = "tcAppointments";
            tcAppointments.SelectedIndex = 0;
            tcAppointments.Size = new Size(890, 410);
            tcAppointments.TabIndex = 0;
            // 
            // tpPatientInfo
            // 
            tpPatientInfo.Controls.Add(btnNext);
            tpPatientInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPatientInfo.Location = new Point(4, 37);
            tpPatientInfo.Name = "tpPatientInfo";
            tpPatientInfo.Padding = new Padding(3);
            tpPatientInfo.Size = new Size(882, 369);
            tpPatientInfo.TabIndex = 0;
            tpPatientInfo.Text = "Patient Info";
            tpPatientInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(750, 292);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 40);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(2, 5);
            ctrlPersonCardWithFilter1.Margin = new Padding(2);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(692, 339);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpAppointmentInfo
            // 
            tpAppointmentInfo.Controls.Add(label4);
            tpAppointmentInfo.Controls.Add(lblAppointmentId);
            tpAppointmentInfo.Controls.Add(label2);
            tpAppointmentInfo.Controls.Add(cbDoctors);
            tpAppointmentInfo.Controls.Add(label1);
            tpAppointmentInfo.Controls.Add(dtpAppointmentDate);
            tpAppointmentInfo.Location = new Point(4, 37);
            tpAppointmentInfo.Name = "tpAppointmentInfo";
            tpAppointmentInfo.Padding = new Padding(3);
            tpAppointmentInfo.Size = new Size(882, 369);
            tpAppointmentInfo.TabIndex = 1;
            tpAppointmentInfo.Text = "Appointment Info";
            tpAppointmentInfo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 60);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 11;
            label4.Text = "Appointment Id:";
            // 
            // lblAppointmentId
            // 
            lblAppointmentId.AutoSize = true;
            lblAppointmentId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointmentId.Location = new Point(243, 60);
            lblAppointmentId.Name = "lblAppointmentId";
            lblAppointmentId.Size = new Size(53, 28);
            lblAppointmentId.TabIndex = 10;
            lblAppointmentId.Text = "[???]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 186);
            label2.Name = "label2";
            label2.Size = new Size(193, 28);
            label2.TabIndex = 9;
            label2.Text = "Appointment Date:";
            // 
            // cbDoctors
            // 
            cbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctors.Font = new Font("Segoe UI", 12F);
            cbDoctors.FormattingEnabled = true;
            cbDoctors.Location = new Point(243, 116);
            cbDoctors.Name = "cbDoctors";
            cbDoctors.Size = new Size(340, 36);
            cbDoctors.TabIndex = 0;
            cbDoctors.SelectedIndexChanged += cbDoctors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 123);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 7;
            label1.Text = "Doctors:";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Font = new Font("Segoe UI", 12F);
            dtpAppointmentDate.Location = new Point(243, 180);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(340, 34);
            dtpAppointmentDate.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.Close_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(780, 485);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 37);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(654, 486);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 37);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.ForeColor = Color.Red;
            lblMode.Location = new Point(319, 9);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(346, 41);
            lblMode.TabIndex = 14;
            lblMode.Text = "Add New Appointment";
            // 
            // frmAddUpdateAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 538);
            Controls.Add(lblMode);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tcAppointments);
            Name = "frmAddUpdateAppointment";
            Text = "frmAddUpdateAppointment";
            Load += frmAddUpdateAppointment_Load;
            tcAppointments.ResumeLayout(false);
            tpPatientInfo.ResumeLayout(false);
            tpAppointmentInfo.ResumeLayout(false);
            tpAppointmentInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tcAppointments;
        private TabPage tpPatientInfo;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private TabPage tpAppointmentInfo;
        private ComboBox cbDoctors;
        private Label label1;
        private DateTimePicker dtpAppointmentDate;
        private Button btnNext;
        private Button btnSave;
        private Button btnClose;
        private Label label4;
        private Label lblAppointmentId;
        private Label label2;
        private Label lblMode;
    }
}