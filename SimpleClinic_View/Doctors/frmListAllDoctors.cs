using SimpleClinic_View.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Doctors
{
    public partial class frmListAllDoctors : Form
    {
        private readonly DoctorApiClient _Doctor;
        public frmListAllDoctors()
        {
            _Doctor = new DoctorApiClient();
            InitializeComponent();
        }



        private async void _RefreshAllDoctorsData()
        {
            dgvListAllDoctors.Rows.Clear();

            var DoctorList = await _Doctor.GetAllDoctorsAsync();

            if (DoctorList != null && DoctorList.Result.Count > 0)
            {
                foreach (var doctor in DoctorList.Result)
                {
                    string formattedDateOfBirth = doctor.DateOfBirth.ToString("yyyy-MM-dd");
                    dgvListAllDoctors.Rows.Add(doctor.Id, doctor.Specialization, doctor.PersonName, doctor.PhoneNumber,
                    doctor.Email, formattedDateOfBirth, doctor.Gender, doctor.Address, doctor.PersonId);
                }
                lblCounter.Text = DoctorList.Result.Count.ToString();
            }
            else
            {
                MessageBox.Show("No Doctors to display.", "Information", MessageBoxButtons.OK);
            }

        }

        private void frmListAllDoctors_Load(object sender, EventArgs e)
        {
            _RefreshAllDoctorsData();
        }

        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = new frmShowDoctorDetails((int)dgvListAllDoctors.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            _RefreshAllDoctorsData();
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmShowDoctorDetails(-1);
            form.ShowDialog();
            _RefreshAllDoctorsData();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmAddEditDoctorinfo((int)dgvListAllDoctors.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            _RefreshAllDoctorsData();

        }



        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditDoctorinfo(-1);
            frm.ShowDialog();
            _RefreshAllDoctorsData();

        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            _RefreshAllDoctorsData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
