namespace SimpleClinic_View.Users
{
    partial class frmLoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginUser));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            chkRemeberMe = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label6 = new Label();
            txtUserName = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 43, 54);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 450);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(239, 403);
            label4.Name = "label4";
            label4.Size = new Size(152, 38);
            label4.TabIndex = 3;
            label4.Text = "Version 1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(185, 158);
            label3.Name = "label3";
            label3.Size = new Size(110, 46);
            label3.TabIndex = 2;
            label3.Text = "(CMS)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 157);
            label2.Name = "label2";
            label2.Size = new Size(126, 46);
            label2.TabIndex = 1;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 111);
            label1.Name = "label1";
            label1.Size = new Size(309, 46);
            label1.TabIndex = 0;
            label1.Text = "Clinic Management";
            // 
            // panel2
            // 
            panel2.Controls.Add(chkRemeberMe);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(405, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 450);
            panel2.TabIndex = 1;
            // 
            // chkRemeberMe
            // 
            chkRemeberMe.AutoSize = true;
            chkRemeberMe.Checked = true;
            chkRemeberMe.CheckState = CheckState.Checked;
            chkRemeberMe.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRemeberMe.Location = new Point(138, 228);
            chkRemeberMe.Name = "chkRemeberMe";
            chkRemeberMe.Size = new Size(150, 29);
            chkRemeberMe.TabIndex = 7;
            chkRemeberMe.Text = "Remember Me";
            chkRemeberMe.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(336, 12);
            button1.Name = "button1";
            button1.Size = new Size(47, 38);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(83, 86);
            label7.Name = "label7";
            label7.Size = new Size(224, 28);
            label7.TabIndex = 5;
            label7.Text = "Login To Your Account";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(224, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(134, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(217, 34);
            txtPassword.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 194);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 2;
            label6.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(134, 139);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(217, 34);
            txtUserName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 142);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 0;
            label5.Text = "Username";
            // 
            // frmLoginUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoginUser";
            Text = "frmLoginUser";
            Load += frmLoginUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtUserName;
        private Label label5;
        private Button button1;
        private Label label7;
        private CheckBox chkRemeberMe;
    }
}