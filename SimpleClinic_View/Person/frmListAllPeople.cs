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
using SimpleClinic_View.Person;

namespace SimpleClinic_View
{
    public partial class frmListAllPeople : Form
    {
        private PersonApiClient _personService;
        public frmListAllPeople()
        {
            InitializeComponent();
            _personService = new PersonApiClient(); // Initialize the service layer
        }

        // Method to refresh the data grid with all people
        private async void _RefreshAllPeopleData()
        {
            try
            {
                dgvListAllPeople.Rows.Clear(); // Clear existing rows before refreshing

                var peopleList = await _personService.GetAllPeople();

                if (peopleList != null && peopleList.Result?.Count > 0)
                {
                    foreach (var person in peopleList.Result)
                    {
                        string formattedDateOfBirth = person.DateOfBirth.ToString("yyyy-MM-dd");
                        dgvListAllPeople.Rows.Add(person.Id, person.PersonName, person.PhoneNumber,
                            person.Email, formattedDateOfBirth, person.Gender, person.Address);
                    }
                    lblCounter.Text = peopleList.Result.Count.ToString();
                }
                else
                {
                    // Show information message if no data is returned
                    MessageBox.Show("No people to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException ex)
            {
                // Display message if a network-related error occurs
                MessageBox.Show("Network error occurred while fetching data. Please check your internet connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Display message for any other errors
                MessageBox.Show("An unexpected error occurred while loading data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load the data when the form opens
        private void frmListAllPeople_Load(object sender, EventArgs e)
        {
            _RefreshAllPeopleData();
        }



        // Add new person logic
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersoninfo(-1); // Open the form for adding new person
            frm.ShowDialog();
            _RefreshAllPeopleData(); // Refresh after adding new person
        }

        // Show details of selected person
        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Guard clause: Check if no row is selected, show a message, and return early.
            if (dgvListAllPeople.CurrentRow == null)
            {
                MessageBox.Show("No person selected for viewing. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the PersonID from the selected row
                int personId = (int)dgvListAllPeople.CurrentRow.Cells[0].Value;

                // Open the details form for the selected person
                Form frm = new frmShowPersonDetails(personId);
                frm.ShowDialog();

                // Refresh the data after viewing the details
                _RefreshAllPeopleData();
            }
            catch (Exception ex)
            {
                // Handle any potential errors gracefully
                MessageBox.Show("An error occurred while trying to show the details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Add new person through menu
        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersoninfo(-1);
            frm.ShowDialog();
            _RefreshAllPeopleData();
        }

       

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dgvListAllPeople.CurrentRow != null)
            {
                // Try to get the PersonID from the selected row
                try
                {
                    int personId = (int)dgvListAllPeople.CurrentRow.Cells[0].Value;
                    Form frm = new frmAddEditPersoninfo(personId);
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    // Handle potential errors during person retrieval or editing
                    MessageBox.Show("An error occurred while trying to edit the person. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh after editing the person
                _RefreshAllPeopleData();
            }
            else
            {
                // Show an error message if no row is selected
                MessageBox.Show("No person selected for editing. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Guard clause: If no row is selected, show a message and exit early.
            if (dgvListAllPeople.CurrentRow == null)
            {
                MessageBox.Show("No person selected for deletion. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Retrieve the PersonID from the selected row
                int personId = (int)dgvListAllPeople.CurrentRow.Cells[0].Value;

                // Ask for confirmation before deleting
                if (MessageBox.Show($"Are you sure you want to delete this person [{personId}]?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var isDeleted = await _personService.DeletePerson(personId);
                        if (isDeleted.IsSuccess)
                        {
                            MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshAllPeopleData(); // Refresh the list after deletion
                        }
                        else
                        {
                            MessageBox.Show("The person could not be deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (HttpRequestException)
                    {
                        MessageBox.Show("Network error occurred while attempting to delete the person. Please check your connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while attempting to delete the person. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while retrieving the person for deletion. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Placeholder for adding a person as a patient
        private void addASPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Person As Patient will be here.");
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Placeholder for adding a person as a doctor
        private void addASDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Person As Doctor will be here.");
        }
    }
}
