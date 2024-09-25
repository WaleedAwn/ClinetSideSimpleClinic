namespace SimpleClinic_View.Payments
{
    partial class frmAddUpdatePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePayment));
            tabControl1 = new TabControl();
            tpAppointmentInfo = new TabPage();
            btnNext = new Button();
            ctrlAppointmentCardWithFilter1 = new Appointments.ctrlAppointmentCardWithFilter();
            tpPaymentInfo = new TabPage();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtAdditionalNotes = new TextBox();
            label5 = new Label();
            txtAmountPaid = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblPaymentId = new Label();
            label2 = new Label();
            cbPaymentMethods = new ComboBox();
            label1 = new Label();
            dtpPaymentDate = new DateTimePicker();
            lblMode = new Label();
            btnSave = new Button();
            btnClose = new Button();
            tabControl1.SuspendLayout();
            tpAppointmentInfo.SuspendLayout();
            tpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpAppointmentInfo);
            tabControl1.Controls.Add(tpPaymentInfo);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1068, 524);
            tabControl1.TabIndex = 6;
            // 
            // tpAppointmentInfo
            // 
            tpAppointmentInfo.Controls.Add(btnNext);
            tpAppointmentInfo.Controls.Add(ctrlAppointmentCardWithFilter1);
            tpAppointmentInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpAppointmentInfo.Location = new Point(4, 37);
            tpAppointmentInfo.Name = "tpAppointmentInfo";
            tpAppointmentInfo.Padding = new Padding(3);
            tpAppointmentInfo.Size = new Size(1060, 483);
            tpAppointmentInfo.TabIndex = 0;
            tpAppointmentInfo.Text = "Appointment Info";
            tpAppointmentInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(929, 435);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 40);
            btnNext.TabIndex = 21;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // ctrlAppointmentCardWithFilter1
            // 
            ctrlAppointmentCardWithFilter1.BackColor = Color.White;
            ctrlAppointmentCardWithFilter1.FilterEnabled = true;
            ctrlAppointmentCardWithFilter1.Location = new Point(8, 10);
            ctrlAppointmentCardWithFilter1.Name = "ctrlAppointmentCardWithFilter1";
            ctrlAppointmentCardWithFilter1.Size = new Size(1049, 419);
            ctrlAppointmentCardWithFilter1.TabIndex = 0;
            // 
            // tpPaymentInfo
            // 
            tpPaymentInfo.Controls.Add(pictureBox5);
            tpPaymentInfo.Controls.Add(pictureBox4);
            tpPaymentInfo.Controls.Add(pictureBox3);
            tpPaymentInfo.Controls.Add(pictureBox2);
            tpPaymentInfo.Controls.Add(pictureBox1);
            tpPaymentInfo.Controls.Add(txtAdditionalNotes);
            tpPaymentInfo.Controls.Add(label5);
            tpPaymentInfo.Controls.Add(txtAmountPaid);
            tpPaymentInfo.Controls.Add(label3);
            tpPaymentInfo.Controls.Add(label4);
            tpPaymentInfo.Controls.Add(lblPaymentId);
            tpPaymentInfo.Controls.Add(label2);
            tpPaymentInfo.Controls.Add(cbPaymentMethods);
            tpPaymentInfo.Controls.Add(label1);
            tpPaymentInfo.Controls.Add(dtpPaymentDate);
            tpPaymentInfo.Location = new Point(4, 37);
            tpPaymentInfo.Name = "tpPaymentInfo";
            tpPaymentInfo.Padding = new Padding(3);
            tpPaymentInfo.Size = new Size(1060, 483);
            tpPaymentInfo.TabIndex = 1;
            tpPaymentInfo.Text = "Payment Info";
            tpPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(212, 264);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 42;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(212, 96);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(212, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(212, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // txtAdditionalNotes
            // 
            txtAdditionalNotes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdditionalNotes.Location = new Point(283, 265);
            txtAdditionalNotes.Multiline = true;
            txtAdditionalNotes.Name = "txtAdditionalNotes";
            txtAdditionalNotes.Size = new Size(339, 95);
            txtAdditionalNotes.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 269);
            label5.Name = "label5";
            label5.Size = new Size(178, 28);
            label5.TabIndex = 37;
            label5.Text = "Additional Notes:";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountPaid.Location = new Point(283, 209);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(339, 34);
            txtAmountPaid.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 213);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 36;
            label3.Text = "Amount Paid:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 45);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 35;
            label4.Text = "Payment Id:";
            // 
            // lblPaymentId
            // 
            lblPaymentId.AutoSize = true;
            lblPaymentId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentId.Location = new Point(282, 45);
            lblPaymentId.Name = "lblPaymentId";
            lblPaymentId.Size = new Size(53, 28);
            lblPaymentId.TabIndex = 34;
            lblPaymentId.Text = "[???]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 157);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 33;
            label2.Text = "Payment Date:";
            // 
            // cbPaymentMethods
            // 
            cbPaymentMethods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentMethods.Font = new Font("Segoe UI", 12F);
            cbPaymentMethods.FormattingEnabled = true;
            cbPaymentMethods.Location = new Point(282, 95);
            cbPaymentMethods.Name = "cbPaymentMethods";
            cbPaymentMethods.Size = new Size(340, 36);
            cbPaymentMethods.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 101);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 32;
            label1.Text = "Payment Methods:";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 12F);
            dtpPaymentDate.Location = new Point(282, 153);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(340, 34);
            dtpPaymentDate.TabIndex = 29;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMode.ForeColor = Color.Red;
            lblMode.Location = new Point(408, -1);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(279, 41);
            lblMode.TabIndex = 20;
            lblMode.Text = "Add New Payment";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Image = Properties.Resources.Close_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(950, 563);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 37);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(816, 563);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 37);
            btnClose.TabIndex = 22;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // frmAddUpdatePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 611);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblMode);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddUpdatePayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Update Payment";
            tabControl1.ResumeLayout(false);
            tpAppointmentInfo.ResumeLayout(false);
            tpPaymentInfo.ResumeLayout(false);
            tpPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tpAppointmentInfo;
        private TabPage tpPaymentInfo;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtAdditionalNotes;
        private Label label5;
        private TextBox txtAmountPaid;
        private Label label3;
        private Label label4;
        private Label lblPaymentId;
        private Label label2;
        private ComboBox cbPaymentMethods;
        private Label label1;
        private DateTimePicker dtpPaymentDate;
        private Appointments.ctrlAppointmentCardWithFilter ctrlAppointmentCardWithFilter1;
        private Label lblMode;
        private Button btnNext;
        private Button btnSave;
        private Button btnClose;
    }
}