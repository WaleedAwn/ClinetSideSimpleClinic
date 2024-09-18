using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using SimpleClinic_View.Patients.DTOs;

namespace SimpleClinic_View.Patients
{
    public class PatientApiClient
    {
        private readonly HttpClient _httpClient;

        public PatientApiClient()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5029/api/Patient/") };
        }
        public async Task<List<AllPatientInfoDTO>> GetAllPatientsAsync()
        {
            List<AllPatientInfoDTO> PatientsList = new List<AllPatientInfoDTO>();

            try
            {
                // Make the API call
                var response = await _httpClient.GetAsync("All");

                // Check if the API call was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content as a list of PersonsDTO
                    var resultList = await response.Content.ReadFromJsonAsync<List<AllPatientInfoDTO>>();

                    // Validate the returned list
                    if (resultList != null && resultList.Count > 0)
                    {
                        foreach (var Patient in resultList)
                        {
                            // Additional validation logic for individual properties if needed
                            if (!string.IsNullOrEmpty(Patient.PersonName) && Patient.DateOfBirth != DateTime.MinValue)
                            {
                                PatientsList.Add(Patient);
                            }
                            else
                            {
                                // Log or handle invalid data (e.g., show a message for invalid entries)
                                MessageBox.Show($"Invalid data for person with ID: {Patient.Id}. Skipping.", "Warning", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else
                    {
                        // Handle case where the response is empty or null
                        MessageBox.Show("No People found in the response.", "Information", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // Handle unsuccessful status code
                    MessageBox.Show($"Failed to fetch People Info : {response.StatusCode}", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK);
            }

            // Return the validated list of students
            return PatientsList;
        }


        public async Task<AllPatientInfoDTO> Find(int PatientID)
        {
            AllPatientInfoDTO patientInfo = null;

            try
            {

                var response = await _httpClient.GetAsync($"Find/{PatientID}");
                if (response.IsSuccessStatusCode)
                {
                    var Person = await response.Content.ReadFromJsonAsync<AllPatientInfoDTO>();
                    if (Person != null)
                    {
                        patientInfo = Person;

                    }
                    else
                    {

                        MessageBox.Show($"There is no  data for Patient with ID: {PatientID}. .", "Warning", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // Handle unsuccessful status code
                    MessageBox.Show($"Failed to fetch Patient Info : {response.StatusCode}", "Error", MessageBoxButtons.OK);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show($"An error occurred While getting Data: {e.Message}", "Error", MessageBoxButtons.OK);
            }
            return patientInfo;
        }
        public async Task<bool> ISPatientExist(int PatientID)
        {
            bool isFound = false;

            try
            {

                var response = await _httpClient.GetAsync($"IsExist/{PatientID}");
                if (response.IsSuccessStatusCode)
                {
                    isFound = true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show($"An error occurred While getting Data: {e.Message}", "Error", MessageBoxButtons.OK);
                return false;
            }
            return isFound;
        }



        public async Task<bool> AddNewPatientAsync(AllPatientInfoDTO newPerson)
        {
            bool isAdded = false;
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Add", newPerson);

                if (response.IsSuccessStatusCode)
                {
                    isAdded = true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    return false;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred While Adding New  Person: {e.Message}", "Error", MessageBoxButtons.OK);

                return false;
            }
            return isAdded;
        }

        public async Task<bool> UpdatePersonInfo(int PersonID, AllPatientInfoDTO UpdatePerson)
        {


            bool isUpdated = false;
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"Update/{PersonID}", UpdatePerson);

                if (response.IsSuccessStatusCode)
                {
                    isUpdated = true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    return false;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred While Updating  Patient Info: {e.Message}", "Error", MessageBoxButtons.OK);

                return false;
            }
            return isUpdated;
        }

        public async Task<bool> DeletePerson(int PersonID)
        {
            bool isdeleted = false;
            try
            {
                var response = await _httpClient.DeleteAsync($"Delete/{PersonID}");

                if (response.IsSuccessStatusCode)
                {
                    isdeleted = true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    return false;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred While Deleting  Person : {e.Message}", "Error", MessageBoxButtons.OK);

                return false;
            }
            return isdeleted;
        }


    }
}
