namespace SimpleClinic_View.Users
{
    partial class frmChangeUserPassword
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
            components = new System.ComponentModel.Container();
            ctrlUserCard1 = new Controls.ctrlUserCard();
            btnSave = new Button();
            btnClose = new Button();
            label3 = new Label();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(12, 21);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(691, 318);
            ctrlUserCard1.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.Close_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(586, 489);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 37);
            btnSave.TabIndex = 3;
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
            btnClose.Location = new Point(452, 489);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 37);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 459);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 17;
            label3.Text = "Confrm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(42, 410);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 16;
            label2.Text = "New Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(198, 453);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(194, 34);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(198, 406);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(194, 34);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 361);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 19;
            label1.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 12F);
            txtCurrentPassword.Location = new Point(198, 359);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(194, 34);
            txtCurrentPassword.TabIndex = 0;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(715, 537);
            Controls.Add(label1);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(ctrlUserCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmChangeUserPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change User Password";
            Load += frmChangeUserPassword_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlUserCard ctrlUserCard1;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private Label label2;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private Label label1;
        private TextBox txtCurrentPassword;
        private ErrorProvider errorProvider1;
    }
}