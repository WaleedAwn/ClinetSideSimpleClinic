namespace SimpleClinic_View.Controls
{
    partial class ctrlPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            gbFilter = new GroupBox();
            btnAddNew = new Button();
            btnFind = new Button();
            txtSearch = new TextBox();
            cbPersonFilters = new ComboBox();
            label8 = new Label();
            epPersonFilter = new ErrorProvider(components);
            ctrlPersonCard1 = new ctrlPersonCard();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epPersonFilter).BeginInit();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddNew);
            gbFilter.Controls.Add(btnFind);
            gbFilter.Controls.Add(txtSearch);
            gbFilter.Controls.Add(cbPersonFilters);
            gbFilter.Controls.Add(label8);
            gbFilter.Font = new Font("Microsoft Sans Serif", 12F);
            gbFilter.Location = new Point(10, 12);
            gbFilter.Margin = new Padding(2);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(2);
            gbFilter.Size = new Size(645, 86);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.White;
            btnAddNew.BackgroundImage = (Image)resources.GetObject("btnAddNew.BackgroundImage");
            btnAddNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNew.Location = new Point(511, 22);
            btnAddNew.Margin = new Padding(2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(47, 54);
            btnAddNew.TabIndex = 4;
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.White;
            btnFind.BackgroundImage = (Image)resources.GetObject("btnFind.BackgroundImage");
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.Location = new Point(458, 22);
            btnFind.Margin = new Padding(2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(47, 54);
            btnFind.TabIndex = 3;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(303, 34);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(136, 30);
            txtSearch.TabIndex = 2;
            // 
            // cbPersonFilters
            // 
            cbPersonFilters.FormattingEnabled = true;
            cbPersonFilters.Items.AddRange(new object[] { "Person ID", "National No" });
            cbPersonFilters.Location = new Point(150, 32);
            cbPersonFilters.Margin = new Padding(2);
            cbPersonFilters.Name = "cbPersonFilters";
            cbPersonFilters.Size = new Size(149, 33);
            cbPersonFilters.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 34);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 0;
            label8.Text = "Find By :";
            // 
            // epPersonFilter
            // 
            epPersonFilter.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(10, 102);
            ctrlPersonCard1.Margin = new Padding(2);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(683, 234);
            ctrlPersonCard1.TabIndex = 3;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ctrlPersonCard1);
            Controls.Add(gbFilter);
            Margin = new Padding(2);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(699, 352);
            Load += ctrlPersonCardWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epPersonFilter).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbFilter;
        private Label label8;
        private ComboBox cbPersonFilters;
        private TextBox txtSearch;
        private Button btnFind;
        private Button btnAddNew;
        private ErrorProvider epPersonFilter;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
