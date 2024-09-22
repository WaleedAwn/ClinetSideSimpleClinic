namespace SimpleClinic_View
{
    partial class TestForm
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
            ctrlPersonCardWithFilter1.Location = new Point(98, 21);
            ctrlPersonCardWithFilter1.Margin = new Padding(2);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(694, 341);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 514);
            Controls.Add(ctrlPersonCardWithFilter1);
            Name = "TestForm";
            Text = "TestForm";
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}