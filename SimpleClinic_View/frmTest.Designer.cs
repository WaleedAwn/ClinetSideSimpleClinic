namespace SimpleClinic_View
{
    partial class frmTest
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
            ctrlPersonCardWithFilter1 = new Controls.ctrlPersonCardWithFilter();
            SuspendLayout();
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(64, 21);
            ctrlPersonCardWithFilter1.Margin = new Padding(2);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(712, 346);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 472);
            Controls.Add(ctrlPersonCardWithFilter1);
            Name = "frmTest";
            Text = "frmTest";
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}