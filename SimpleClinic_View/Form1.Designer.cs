﻿namespace SimpleClinic_View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnPatient = new Button();
            btnUsers = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(362, 76);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(81, 27);
            button1.TabIndex = 0;
            button1.Text = "Perspn ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPatient
            // 
            btnPatient.Location = new Point(362, 172);
            btnPatient.Margin = new Padding(2, 2, 2, 2);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(81, 27);
            btnPatient.TabIndex = 1;
            btnPatient.Text = "Patient ";
            btnPatient.UseVisualStyleBackColor = true;
            btnPatient.Click += btnPatient_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(181, 76);
            btnUsers.Margin = new Padding(2, 2, 2, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(81, 27);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 676);
            Controls.Add(button2);
            Controls.Add(btnUsers);
            Controls.Add(btnPatient);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnPatient;
        private Button btnUsers;
        private Button button2;
    }
}
