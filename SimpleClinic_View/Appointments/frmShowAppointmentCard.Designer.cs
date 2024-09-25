namespace SimpleClinic_View.Appointments
{
    partial class frmShowAppointmentCard
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
            lblMode = new Label();
            ctrlAppointmentCard1 = new ctrlAppointmentCard();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.ForeColor = Color.Red;
            lblMode.Location = new Point(365, 2);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(312, 41);
            lblMode.TabIndex = 15;
            lblMode.Text = "Appointment Details";
            // 
            // ctrlAppointmentCard1
            // 
            ctrlAppointmentCard1.BackColor = Color.White;
            ctrlAppointmentCard1.Location = new Point(10, 62);
            ctrlAppointmentCard1.Name = "ctrlAppointmentCard1";
            ctrlAppointmentCard1.Size = new Size(1051, 564);
            ctrlAppointmentCard1.TabIndex = 16;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(928, 632);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(133, 47);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowAppointmentCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1072, 687);
            Controls.Add(btnClose);
            Controls.Add(ctrlAppointmentCard1);
            Controls.Add(lblMode);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowAppointmentCard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Show Appointment Details";
            Load += frmShowAppointmentCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMode;
        private ctrlAppointmentCard ctrlAppointmentCard1;
        private Button btnClose;
    }
}