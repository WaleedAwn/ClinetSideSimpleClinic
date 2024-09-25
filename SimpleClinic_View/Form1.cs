
using SimpleClinic_View.Doctors;
using SimpleClinic_View.Users;
using SimpleClinic_View.MedicalRecords.ListMedicalRecods;
    namespace SimpleClinic_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListAllPeople();
            frm.ShowDialog();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Form frm = new frmListAllPatients();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();

            frm.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Form frm =new frmListAllDoctors();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new ListMedicalRecod();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
