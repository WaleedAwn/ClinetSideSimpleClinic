using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, SimpleClinic_View.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs e)
        {
            MessageBox.Show($"{e.PersonId} , {e.PatientId}");
        }
    }
}
