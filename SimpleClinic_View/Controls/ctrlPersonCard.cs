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
using SimpleClinic_View.DTOs;
using SimpleClinic_View.Service;

namespace SimpleClinic_View.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private readonly PersonService personService;
     
        int _PersonID;

        public ctrlPersonCard()
        {
            InitializeComponent();
            personService = new PersonService();

        }
        public async void _LoadPersonData(int _PersonID)
        {
            PersonsDTO person = await personService.Find(_PersonID);

            if (person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                return;
            }
            else
            {
                string formattedDateOfBirth = person.DateOfBirth.ToString("yyyy-MM-dd");
                lbPersonID.Text = person.Id.ToString();
                lblName.Text = person.PersonName.ToString();
                lblPhone.Text = person.PhoneNumber.ToString();
                lblEmail.Text = person.Email.ToString();
                lblDateOfBirth.Text = formattedDateOfBirth.ToString();
                lblAddress.Text = person.Address.ToString();
                lblGender.Text = person.Gender.ToString();

            }


        }

        public  void ResetDeffultValues()
        {
             
               
                lbPersonID.Text = "[???]";
                lblName.Text    = "[???]";
                lblPhone.Text   = "[???]";
                 lblEmail.Text = "[???]";
                  lblDateOfBirth.Text = "[???]";
                lblAddress.Text ="[???]";
                lblGender.Text = "[???]";
          
            


        }


        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
