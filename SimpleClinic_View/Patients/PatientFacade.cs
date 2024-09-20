using SimpleClinic_View.Globals;
using SimpleClinic_View.Patients.DTOs;
using SimpleClinic_View.Person;
using SimpleClinic_View.Person.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Patients
{
    public interface IPatientFacade
    {
        Task<ApiResult<AllPatientInfoDTO>> CreatePatientAsync(PersonsDTO personDto, PatientDTO patientDto);
        Task<ApiResult<AllPatientInfoDTO>> GetPatientAsync(int patientId);
        Task<ApiResult<AllPatientInfoDTO>> UpdatePatientAsync(int patientId, PersonsDTO updatedPersonDto, PatientDTO updatedPatientDto);
        Task<ApiResult<bool>> DeletePatientAsync(int patientId);
    }

    public class PatientFacade : IPatientFacade
    {
        private readonly PersonApiClient _personApiClient;
        private readonly PatientApiClient _patientApiClient;

        public PatientFacade()
        {
            _personApiClient = new PersonApiClient();
            _patientApiClient = new PatientApiClient();
        }


        public async Task<ApiResult<AllPatientInfoDTO>> CreatePatientAsync(PersonsDTO personDto, PatientDTO patientDto)
        {
            var personResult = await _personApiClient.AddNewPerson(personDto);

            if (!personResult.IsSuccess)
            {
                return new ApiResult<AllPatientInfoDTO>
                {
                    IsSuccess = false,
                    ErrorMessage = "Failed to create person. " + personResult.ErrorMessage
                };
            }
            if (personResult.Result != null)
            {
                // Use the PersonId from the created Person to associate it with the Patient
                patientDto.PersonId = personResult.Result.Id;
                var patientResult = await _patientApiClient.AddNewPatientAsync(patientDto);

                return patientResult;
            }
            else
            {
                return new ApiResult<AllPatientInfoDTO>
                {
                    IsSuccess = false,
                    ErrorMessage = "Failed to create person. " + personResult.ErrorMessage
                };
            }

        }


        public async Task<ApiResult<AllPatientInfoDTO>> GetPatientAsync(int patientId)
        {
            var Result = await _patientApiClient.Find(patientId); ;
            return Result;
        }



        public async Task<ApiResult<AllPatientInfoDTO>> UpdatePatientAsync(int patientId, PersonsDTO person, PatientDTO patient)
        {
            // Step 1: Update the person details
            int personId = person.Id;
            var personResult = await _personApiClient.UpdatePersonInfo(personId, person);

            if (!personResult.IsSuccess)
            {
                return new ApiResult<AllPatientInfoDTO>
                {
                    IsSuccess = personResult.IsSuccess,
                    Status = personResult.Status,
                    ErrorMessage = personResult.ErrorMessage
                };
            }

            // Step 2: Update the patient details
            //patient.PersonId = personId;
            //var patientResult = await _patientApiClient.UpdatePatientInfo(patientId, patient);

            //if (!patientResult.IsSuccess)
            //{
            //    return new ApiResult<AllPatientInfoDTO>
            //    {
            //        IsSuccess = false,
            //        Status = patientResult.Status,
            //        ErrorMessage = patientResult.ErrorMessage
            //    };
            //}

            // Step 3: Return the combined result
            return new ApiResult<AllPatientInfoDTO>
            {
                IsSuccess = true,
                Status = ApiResponseStatus.Success,
                Result = new AllPatientInfoDTO
                {
                    Id = patient.Id,
                    personId = personId,
                    PersonName = person.PersonName,
                    DateOfBirth = person.DateOfBirth,
                    Gender = person.Gender,
                    PhoneNumber = person.PhoneNumber,
                    Email = person.Email,
                    Address = person.Address
                }
            };
        }




        public async Task<ApiResult<bool>> DeletePatientAsync(int patientId)
        {
            // Check if the patient exists
            var patientResult = await _patientApiClient.Find(patientId);
            if (!patientResult.IsSuccess)
            {
                return new ApiResult<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Failed to find patient. " + patientResult.ErrorMessage
                };
            }

            // Delete the Patient
            var deletePatientResult = await _patientApiClient.DeletePatient(patientId);
            if (!deletePatientResult.IsSuccess)
            {
                return deletePatientResult;
            }

            if (patientResult.Result != null)
            {
                // Then delete the associated Person
                var deletePersonResult = await _personApiClient.DeletePerson(patientResult.Result.personId);
                return deletePersonResult;
            }

            return new ApiResult<bool>
            {
                IsSuccess = false,
                ErrorMessage = "Failed to find patient. " + patientResult.ErrorMessage
            };


        }

        static public async Task<ApiResult<bool>> DeletePatient(int patientId)
        {
            var facade = new PatientFacade();
            return await facade.DeletePatientAsync(patientId);
        }

        // i Will USe this Way To Avoid Create Object With all Patient Date 
        public async Task<ApiResult<bool>> DeletePatientWithPerson(int personId, int patientId)
        {
            // Step 1: Delete the patient record
            var patientResult = await _patientApiClient.DeletePatient(patientId);

            if (!patientResult.IsSuccess)
            {
                return new ApiResult<bool>
                {
                    IsSuccess = false,
                    Status = patientResult.Status,
                    ErrorMessage = patientResult.ErrorMessage
                };
            }

            // Step 2: Delete the associated person record
            var personResult = await _personApiClient.DeletePerson(personId);

            if (!personResult.IsSuccess)
            {
                return new ApiResult<bool>
                {
                    IsSuccess = false,
                    Status = personResult.Status,
                    ErrorMessage = personResult.ErrorMessage
                };
            }

            // Step 3: Return success
            return new ApiResult<bool>
            {
                IsSuccess = true,
                Status = ApiResponseStatus.Success,
                Result = true
            };
        }
      static  public async Task<ApiResult<bool>> DeletePatientWithPersonAsync(int personId, int patientId)
        {
            var facade = new PatientFacade();
            return await facade.DeletePatientWithPerson(personId, patientId);


        }




    }

}

