using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.Person;
using SimpleClinic_View.Person.DTOs;


namespace SimpleClinic_View.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private  PersonApiClient personService;

        int _PersonID;

        public ctrlPersonCard()
        {
            InitializeComponent();
            personService = new PersonApiClient();

        }
        public async void _LoadPersonData(int _PersonID)
        {
            var person = await personService.Find(_PersonID);

            if (person.Result == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                return;
            }
            else
            {
                string formattedDateOfBirth = person.Result.DateOfBirth.ToString("yyyy-MM-dd");
                lbPersonID.Text = person.Result.Id.ToString();
                lblName.Text = person.Result.PersonName.ToString();
                lblPhone.Text = person.Result.PhoneNumber.ToString();
                lblEmail.Text = person.Result.Email.ToString();
                lblDateOfBirth.Text = formattedDateOfBirth.ToString();
                lblAddress.Text = person.Result.Address.ToString();
                lblGender.Text = person.Result.Gender.ToString();

            }


        }

        public void ResetDeffultValues()
        {


            lbPersonID.Text = "[???]";
            lblName.Text = "[???]";
            lblPhone.Text = "[???]";
            lblEmail.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblAddress.Text = "[???]";
            lblGender.Text = "[???]";




        }


        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void PnPersoncard_Enter(object sender, EventArgs e)
        {

        }
    }
}
