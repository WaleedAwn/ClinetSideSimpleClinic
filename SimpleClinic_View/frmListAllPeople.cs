using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using SimpleClinic_View.DTOs;
using SimpleClinic_View.Service;


namespace SimpleClinic_View
{
    public partial class frmListAllPeople : Form
    {
        private readonly PersonService _personService;

        public frmListAllPeople()
        {
            InitializeComponent();
            _personService = new PersonService(); // Initialize the service layer
        }

        private async void _RefreshAllPeopleData()
        {
            dgvListAllPeople.Rows.Clear();

            List<PersonsDTO> peopleList = await _personService.GetAllPeople();

            if (peopleList != null && peopleList.Count > 0)
            {
                foreach (var person in peopleList)
                {
                    string formattedDateOfBirth = person.DateOfBirth.ToString("yyyy-MM-dd");
                    dgvListAllPeople.Rows.Add(person.Id, person.PersonName, person.PhoneNumber,
                    person.Email, formattedDateOfBirth, person.Gender, person.Address);
                }
                lblCounter.Text = peopleList.Count.ToString();
            }
            else
            {
                MessageBox.Show("No people to display.", "Information", MessageBoxButtons.OK);
            }


        }


        private void frmListAllPeople_Load(object sender, EventArgs e)
        {
            _RefreshAllPeopleData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersoninfo(-1);
            frm.ShowDialog();
            _RefreshAllPeopleData();

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonDetails((int)dgvListAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAllPeopleData();
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersoninfo(-1);
            frm.ShowDialog();
            _RefreshAllPeopleData();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersoninfo((int)dgvListAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshAllPeopleData();

        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PersonId = (int)dgvListAllPeople.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete thisPerson [" + PersonId + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (await _personService.DeletePerson(PersonId))
                {
                    MessageBox.Show("Person deleted Successfully.");
                    _RefreshAllPeopleData();
                }
                else
                {
                    MessageBox.Show("Person is not  Deleted.");

                }


            }


        }
    }
}
