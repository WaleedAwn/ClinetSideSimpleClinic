using SimpleClinic_View.ApiClients;
using SimpleClinic_View.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Service
{
    public class PersonService
    {
        private readonly PersonApiClient _personApiClient;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public PersonService()
        {
            // Pass the API base URL to the client
            _personApiClient = new PersonApiClient("http://localhost:5029/api/Persons/");
            _Mode=enMode.AddNew;    
        }

        public async Task<List<PersonsDTO>> GetAllPeople()
        {
            return await _personApiClient.GetAllPeopleAsync();
        }

        public async Task<PersonsDTO>Find(int id)
        {
            return await _personApiClient.Find(id);
        }

        public async Task<int> AddNewPerson(PersonsDTO NewPerson)
        {
            return await _personApiClient.AddNewPersonAsync(NewPerson);

        }

        public async Task<bool> UpdatePerson(int id,PersonsDTO UpdatePerson)
        {
            return await _personApiClient.UpdatePersonInfo(id, UpdatePerson);

        }

        public async Task<bool> DeletePerson(int id)
        {
            return await _personApiClient.DeletePerson(id);

        }

        public async Task<bool> ISPersonExist(int id)
        {
            return await _personApiClient.ISPersonExist(id);

        }


        //public bool Save()
        //{
          

        // }

    }
}
