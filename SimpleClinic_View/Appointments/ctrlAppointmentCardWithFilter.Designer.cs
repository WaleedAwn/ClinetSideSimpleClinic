namespace SimpleClinic_View.Appointments
{
    partial class ctrlAppointmentCardWithFilter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAppointmentCardWithFilter));
            gbFilter = new GroupBox();
            btnAddNew = new Button();
            btnFind = new Button();
            txtSearch = new TextBox();
            cbAppointmentFilters = new ComboBox();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ctrlAppointmentCardMini1 = new ctrlAppointmentCardMini();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddNew);
            gbFilter.Controls.Add(btnFind);
            gbFilter.Controls.Add(txtSearch);
            gbFilter.Controls.Add(cbAppointmentFilters);
            gbFilter.Controls.Add(label8);
            gbFilter.Font = new Font("Microsoft Sans Serif", 12F);
            gbFilter.Location = new Point(4, 4);
            gbFilter.Margin = new Padding(2);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(2);
            gbFilter.Size = new Size(818, 86);
            gbFilter.TabIndex = 3;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.White;
            btnAddNew.BackgroundImage = (Image)resources.GetObject("btnAddNew.BackgroundImage");
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.Location = new Point(735, 18);
            btnAddNew.Margin = new Padding(2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(69, 57);
            btnAddNew.TabIndex = 4;
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.White;
            btnFind.BackgroundImage = (Image)resources.GetObject("btnFind.BackgroundImage");
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.Location = new Point(657, 18);
            btnFind.Margin = new Padding(2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(69, 57);
            btnFind.TabIndex = 3;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(373, 32);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(268, 30);
            txtSearch.TabIndex = 2;
            txtSearch.KeyPress += txtSearch_KeyPress;
            txtSearch.Validating += txtSearch_Validating;
            // 
            // cbAppointmentFilters
            // 
            cbAppointmentFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAppointmentFilters.FormattingEnabled = true;
            cbAppointmentFilters.Items.AddRange(new object[] { "Appointment Id" });
            cbAppointmentFilters.Location = new Point(150, 32);
            cbAppointmentFilters.Margin = new Padding(2);
            cbAppointmentFilters.Name = "cbAppointmentFilters";
            cbAppointmentFilters.Size = new Size(219, 33);
            cbAppointmentFilters.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 34);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 0;
            label8.Text = "Find By :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlAppointmentCardMini1
            // 
            ctrlAppointmentCardMini1.BackColor = Color.White;
            ctrlAppointmentCardMini1.Location = new Point(6, 93);
            ctrlAppointmentCardMini1.Name = "ctrlAppointmentCardMini1";
            ctrlAppointmentCardMini1.Size = new Size(1046, 326);
            ctrlAppointmentCardMini1.TabIndex = 4;
            // 
            // ctrlAppointmentCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ctrlAppointmentCardMini1);
            Controls.Add(gbFilter);
            Name = "ctrlAppointmentCardWithFilter";
            Size = new Size(1055, 418);
            Load += ctrlAppointmentCardWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFilter;
        private Button btnAddNew;
        private Button btnFind;
        private TextBox txtSearch;
        private ComboBox cbAppointmentFilters;
        private Label label8;
        private ErrorProvider errorProvider1;
        private ctrlAppointmentCardMini ctrlAppointmentCardMini1;
    }
}
