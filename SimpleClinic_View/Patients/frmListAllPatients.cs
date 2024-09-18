using SimpleClinic_View.Patients;
using SimpleClinic_View.Patients.DTOs;
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
    public partial class frmListAllPatients : Form
    {
        private readonly PatientApiClient _Patient;
        public frmListAllPatients()
        {
            _Patient = new PatientApiClient();
            InitializeComponent();
        }



        private async void _RefreshAllPatientsData()
        {
            dgvListAllPatients.Rows.Clear();

            List<AllPatientInfoDTO> peopleList = await _Patient.GetAllPatientsAsync();

            if (peopleList != null && peopleList.Count > 0)
            {
                foreach (var person in peopleList)
                {
                    string formattedDateOfBirth = person.DateOfBirth.ToString("yyyy-MM-dd");
                    dgvListAllPatients.Rows.Add(person.Id, person.PersonName, person.PhoneNumber,
                    person.Email, formattedDateOfBirth, person.Gender, person.Address);
                }
                lblCounter.Text = peopleList.Count.ToString();
            }
            else
            {
                MessageBox.Show("No Patient to display.", "Information", MessageBoxButtons.OK);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListAllPatients_Load(object sender, EventArgs e)
        {
            _RefreshAllPatientsData();
        }

        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewpatient_Click(object sender, EventArgs e)
        {
            Form fr = new frmAddEditPatientinfo(-1);
            fr.ShowDialog();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPatientinfo((int)dgvListAllPatients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshAllPatientsData();
        }
    }
}
