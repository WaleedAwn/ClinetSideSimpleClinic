using SimpleClinic_View.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace SimpleClinic_View.ApiClients
{
    public class PersonApiClient
    {
        private readonly HttpClient _httpClient;

        public PersonApiClient(string baseUrl )
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
        }
        public async Task<List<PersonsDTO>> GetAllPeopleAsync()
        {
            List<PersonsDTO> peopleList = new List<PersonsDTO>();

            try
            {
                // Make the API call
                var response = await _httpClient.GetAsync("All");

                // Check if the API call was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content as a list of PersonsDTO
                    var resultList = await response.Content.ReadFromJsonAsync<List<PersonsDTO>>();

                    // Validate the returned list
                    if (resultList != null && resultList.Count > 0)
                    {
                        foreach (var person in resultList)
                        {
                            // Additional validation logic for individual properties if needed
                            if (!string.IsNullOrEmpty(person.PersonName) && person.DateOfBirth != DateTime.MinValue)
                            {
                                peopleList.Add(person);
                            }
                            else
                            {
                                // Log or handle invalid data (e.g., show a message for invalid entries)
                                MessageBox.Show($"Invalid data for person with ID: {person.Id}. Skipping.", "Warning", MessageBoxButtons.OK);
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
            return peopleList;
        }
        
        public async Task<PersonsDTO> Find(int PersonID)
        {
            PersonsDTO personInfo = null;

            try
            {

                var response = await _httpClient.GetAsync($"Find/{PersonID}");
                if (response.IsSuccessStatusCode)
                {
                    var Person=await response.Content.ReadFromJsonAsync<PersonsDTO>();
                    if (Person!=null)
                    {
                        personInfo = Person;

                    }
                    else
                    {
                     
                        MessageBox.Show($"There is no  data for person with ID: {PersonID}. .", "Warning", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // Handle unsuccessful status code
                    MessageBox.Show($"Failed to fetch People Info : {response.StatusCode}", "Error", MessageBoxButtons.OK);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show($"An error occurred While getting Data: {e.Message}", "Error", MessageBoxButtons.OK);
            }
            return personInfo;
        }
        public async Task<bool> ISPersonExist(int PersonID)
        {
           bool isFound=false;

            try
            {

                var response = await _httpClient.GetAsync($"IsExist/{PersonID}");
                if (response.IsSuccessStatusCode)
                {
                   isFound=true;
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



        public async Task<bool> AddNewPersonAsync(PersonsDTO newPerson)
        {
            bool isAdded = false;
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Add", newPerson);

                if (response.IsSuccessStatusCode)
                {
                    isAdded=true;
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

        public async Task<bool> UpdatePersonInfo(int PersonID,PersonsDTO UpdatePerson)
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
                MessageBox.Show($"An error occurred While Updating  Person Info: {e.Message}", "Error", MessageBoxButtons.OK);

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
