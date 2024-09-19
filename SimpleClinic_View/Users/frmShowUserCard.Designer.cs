namespace SimpleClinic_View.Users
{
    partial class frmShowUserCard
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
            ctrlUserCard1 = new Controls.ctrlUserCard();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(12, 68);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(699, 316);
            ctrlUserCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(272, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 36);
            label1.TabIndex = 2;
            label1.Text = "User Details";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(577, 389);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 44);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowUserCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(712, 444);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlUserCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowUserCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowUserCard";
            Load += frmShowUserCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlUserCard ctrlUserCard1;
        private Label label1;
        private Button btnClose;
    }
}