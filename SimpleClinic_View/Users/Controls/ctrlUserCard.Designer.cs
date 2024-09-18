namespace SimpleClinic_View.Users.Controls
{
    partial class ctrlUserCard
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
            ctrlPersonCard1 = new SimpleClinic_View.Controls.ctrlPersonCard();
            gbUserInfo = new GroupBox();
            lblUserID = new Label();
            label1 = new Label();
            lblUsername = new Label();
            label3 = new Label();
            gbUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(2, 2);
            ctrlPersonCard1.Margin = new Padding(2);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(682, 231);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbUserInfo
            // 
            gbUserInfo.Controls.Add(lblUsername);
            gbUserInfo.Controls.Add(label3);
            gbUserInfo.Controls.Add(lblUserID);
            gbUserInfo.Controls.Add(label1);
            gbUserInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbUserInfo.Location = new Point(3, 238);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Size = new Size(681, 72);
            gbUserInfo.TabIndex = 1;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "User Info";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Microsoft Sans Serif", 12F);
            lblUserID.Location = new Point(213, 30);
            lblUserID.Margin = new Padding(2, 0, 2, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(68, 25);
            lblUserID.TabIndex = 9;
            lblUserID.Text = "[????]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(109, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 8;
            label1.Text = "User ID:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F);
            lblUsername.Location = new Point(446, 30);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(68, 25);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "[????]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(325, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 10;
            label3.Text = "Username:";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbUserInfo);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserCard";
            Size = new Size(692, 321);
            gbUserInfo.ResumeLayout(false);
            gbUserInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SimpleClinic_View.Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbUserInfo;
        private Label lblUsername;
        private Label label3;
        private Label lblUserID;
        private Label label1;
    }
}
