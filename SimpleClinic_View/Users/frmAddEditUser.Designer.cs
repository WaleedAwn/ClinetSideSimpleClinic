namespace SimpleClinic_View.Users
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            tcUserInfo = new TabControl();
            tpPersonInfo = new TabPage();
            btnNext = new Button();
            ctrlPersonCardWithFilter1 = new SimpleClinic_View.Controls.ctrlPersonCardWithFilter();
            tpUserInfo = new TabPage();
            lblUserId = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblMode = new Label();
            btnClose = new Button();
            btnSave = new Button();
            tcUserInfo.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            tpUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tcUserInfo
            // 
            tcUserInfo.Controls.Add(tpPersonInfo);
            tcUserInfo.Controls.Add(tpUserInfo);
            tcUserInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tcUserInfo.Location = new Point(12, 79);
            tcUserInfo.Name = "tcUserInfo";
            tcUserInfo.SelectedIndex = 0;
            tcUserInfo.Size = new Size(897, 442);
            tcUserInfo.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.Controls.Add(btnNext);
            tpPersonInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonInfo.Location = new Point(4, 37);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new Padding(3);
            tpPersonInfo.Size = new Size(889, 401);
            tpPersonInfo.TabIndex = 0;
            tpPersonInfo.Text = "Person Info";
            tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(738, 325);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 40);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(2, 37);
            ctrlPersonCardWithFilter1.Margin = new Padding(2);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(721, 342);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpUserInfo
            // 
            tpUserInfo.Controls.Add(lblUserId);
            tpUserInfo.Controls.Add(label4);
            tpUserInfo.Controls.Add(label3);
            tpUserInfo.Controls.Add(label2);
            tpUserInfo.Controls.Add(label1);
            tpUserInfo.Controls.Add(textBox3);
            tpUserInfo.Controls.Add(txtPassword);
            tpUserInfo.Controls.Add(txtUserName);
            tpUserInfo.Location = new Point(4, 37);
            tpUserInfo.Name = "tpUserInfo";
            tpUserInfo.Padding = new Padding(3);
            tpUserInfo.Size = new Size(889, 401);
            tpUserInfo.TabIndex = 1;
            tpUserInfo.Text = "User Info";
            tpUserInfo.UseVisualStyleBackColor = true;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(227, 84);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(48, 28);
            lblUserId.TabIndex = 7;
            lblUserId.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 84);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 6;
            label4.Text = "User ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 251);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 5;
            label3.Text = "Confrm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 197);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 139);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 3;
            label1.Text = "User Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(227, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 34);
            textBox3.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 34);
            txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(227, 139);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 34);
            txtUserName.TabIndex = 0;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Microsoft Sans Serif", 18F);
            lblMode.Location = new Point(362, 29);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(209, 36);
            lblMode.TabIndex = 5;
            lblMode.Text = "Add New User";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(652, 522);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 37);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.Close_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(786, 522);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 37);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 569);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblMode);
            Controls.Add(tcUserInfo);
            Name = "frmAddEditUser";
            Text = "frmAddEditUser";
            tcUserInfo.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            tpUserInfo.ResumeLayout(false);
            tpUserInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tcUserInfo;
        private TabPage tpPersonInfo;
        private TabPage tpUserInfo;
        private SimpleClinic_View.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Label lblMode;
        private Button btnNext;
        private TextBox textBox3;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnClose;
        private Button btnSave;
        private Label lblUserId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}