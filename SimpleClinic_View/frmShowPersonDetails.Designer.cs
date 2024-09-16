namespace SimpleClinic_View
{
    partial class frmShowPersonDetails
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
            lblAddEditPerson = new Label();
            ctrlPersonCard1 = new Controls.ctrlPersonCard();
            btnClose = new Button();
            btnAddNew = new PictureBox();
            btnEditInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)btnAddNew).BeginInit();
            SuspendLayout();
            // 
            // lblAddEditPerson
            // 
            lblAddEditPerson.AutoSize = true;
            lblAddEditPerson.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddEditPerson.ForeColor = Color.Red;
            lblAddEditPerson.Location = new Point(314, 20);
            lblAddEditPerson.Name = "lblAddEditPerson";
            lblAddEditPerson.Size = new Size(250, 45);
            lblAddEditPerson.TabIndex = 1;
            lblAddEditPerson.Text = "Person Detailes";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(12, 206);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(838, 307);
            ctrlPersonCard1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(868, 540);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 53);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackgroundImage = Properties.Resources.Add_Person_40;
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.BorderStyle = BorderStyle.FixedSingle;
            btnAddNew.Location = new Point(931, 139);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(100, 74);
            btnAddNew.TabIndex = 10;
            btnAddNew.TabStop = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnEditInfo
            // 
            btnEditInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditInfo.Location = new Point(736, 166);
            btnEditInfo.Name = "btnEditInfo";
            btnEditInfo.Size = new Size(154, 47);
            btnEditInfo.TabIndex = 11;
            btnEditInfo.Text = "Edit Info";
            btnEditInfo.UseVisualStyleBackColor = true;
            btnEditInfo.Click += btnEditInfo_Click;
            // 
            // frmShowPersonDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 617);
            Controls.Add(btnEditInfo);
            Controls.Add(btnAddNew);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(lblAddEditPerson);
            Name = "frmShowPersonDetails";
            Text = "frmShowPersonDetails";
            Load += frmShowPersonDetails_Load;
            ((System.ComponentModel.ISupportInitialize)btnAddNew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard1;
        private Label lblAddEditPerson;
        private Button btnClose;
        private PictureBox btnAddNew;
        private Button btnEditInfo;
    }
}