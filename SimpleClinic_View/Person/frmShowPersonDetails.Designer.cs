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
            lblAddEditPerson.Location = new Point(228, 16);
            lblAddEditPerson.Margin = new Padding(2, 0, 2, 0);
            lblAddEditPerson.Name = "lblAddEditPerson";
            lblAddEditPerson.Size = new Size(215, 37);
            lblAddEditPerson.TabIndex = 1;
            lblAddEditPerson.Text = "Person Detailes";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(9, 165);
            ctrlPersonCard1.Margin = new Padding(1, 2, 1, 2);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(609, 246);
            ctrlPersonCard1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(631, 432);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 42);
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
            btnAddNew.Location = new Point(677, 111);
            btnAddNew.Margin = new Padding(2, 2, 2, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(73, 60);
            btnAddNew.TabIndex = 10;
            btnAddNew.TabStop = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnEditInfo
            // 
            btnEditInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditInfo.Location = new Point(535, 133);
            btnEditInfo.Margin = new Padding(2, 2, 2, 2);
            btnEditInfo.Name = "btnEditInfo";
            btnEditInfo.Size = new Size(112, 38);
            btnEditInfo.TabIndex = 11;
            btnEditInfo.Text = "Edit Info";
            btnEditInfo.UseVisualStyleBackColor = true;
            btnEditInfo.Click += btnEditInfo_Click;
            // 
            // frmShowPersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 494);
            Controls.Add(btnEditInfo);
            Controls.Add(btnAddNew);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(lblAddEditPerson);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmShowPersonDetails";
            StartPosition = FormStartPosition.CenterScreen;
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