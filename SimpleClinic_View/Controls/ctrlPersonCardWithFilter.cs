using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Person;
using SimpleClinic_View.Person.DTOs;
using SimpleClinic_View.Users;
using SimpleClinic_View.Users.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        public class PersonSelectedEventArgs : EventArgs
        {
            public int PersonId { get; } 
            public int PatientId { get; } 
            
            public PersonSelectedEventArgs(int personId, int patientId)
            {
                this.PersonId = personId;
                this.PatientId = patientId;
            }
        }
        //define the event 
        public event EventHandler<PersonSelectedEventArgs> OnPersonSelected;

        public void RaisOnPersonSelectd(int personId, int patientId)
        {
            RaisOnPersonSelectd(new PersonSelectedEventArgs(personId, patientId));

        }

        protected virtual void RaisOnPersonSelectd(PersonSelectedEventArgs e)
        {
            OnPersonSelected?.Invoke(this, e);
        }


        private ApiResult<PersonsDTO> _apiResult;
        private int _personId = -1;
        public int PersonId
        {
            get
            {
               return ctrlPersonCard1.PersonId;
            }
        }
        public int PatientId
        {
            get
            {
                return ctrlPersonCard1.PatientId;
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNew.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        public ApiResult<PersonsDTO> SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
            _apiResult = new ApiResult<PersonsDTO>();
        }

        public void DeleteItemFromFilter(int index)
        {
            cbPersonFilters.Items.RemoveAt(index);
            if(cbPersonFilters.Items.Count >0)
                cbPersonFilters.SelectedIndex = 0;
        }

        public  void LoadPersonInfo(int PersonID)
        {
            
            cbPersonFilters.SelectedIndex = 0;
            txtSearch.Text = PersonID.ToString();
            FindNow();

        }

        private async void FindNow()
        {
             switch (cbPersonFilters.Text)
            {
                
                case "Person ID":
                     await ctrlPersonCard1._LoadPersonData(int.Parse(txtSearch.Text));

                    break;
                case "Patient ID":
                    await ctrlPersonCard1._LoadPatientData(int.Parse(txtSearch.Text));
                    break;

                case "National No":
                    //ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    MessageBox.Show("Filter by national No not implemented yet!", "Soon!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                RaisOnPersonSelectd(ctrlPersonCard1.PersonId,ctrlPersonCard1.PatientId);
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            FindNow();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditPersoninfo frm = new frmAddEditPersoninfo(-1);
            frm.DataBack += AddNewPerson_DataBack;
            frm.ShowDialog();
        }

        private void AddNewPerson_DataBack(object sender, int PersonID)
        {
            cbPersonFilters.SelectedIndex = 0;
            txtSearch.Text = PersonID.ToString();
            _personId = PersonID;
            cbPersonFilters.Focus();
            ctrlPersonCard1._LoadPersonData(PersonID);
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbPersonFilters.SelectedIndex = 0;
            txtSearch.Focus();
        }

        private void cbPersonFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                //e.Cancel = true;
                epPersonFilter.SetError(txtSearch, "This field is required!");

            }
            else
                epPersonFilter.SetError(txtSearch, null);
        }

        public void FilterFocus()
        {
            txtSearch.Focus();    
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            if (cbPersonFilters.Text == "Person ID" || cbPersonFilters.Text == "Patient ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
