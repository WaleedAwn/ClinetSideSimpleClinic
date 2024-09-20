using SimpleClinic_View.Doctors.DTOs;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Person;
using SimpleClinic_View.Person.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleClinic_View.Doctors
{
    public interface IDoctorFacade
    {
        Task<ApiResult<List<AllDoctorsInfoDTO>>> GetAllDoctorsAsync();
        Task<ApiResult<AllDoctorsInfoDTO>> GetDoctorByIdAsync(int doctorId);
        Task<ApiResult<AllDoctorsInfoDTO>> CreateDoctorWithPersonAsync(PersonsDTO personDto, DoctorsDTO doctorDto);
        Task<ApiResult<AllDoctorsInfoDTO>> UpdateDoctorWithPersonAsync(int doctorId, PersonsDTO updatedPersonDto, DoctorsDTO updatedDoctorDto);
        Task<ApiResult<bool>> DeleteDoctorWithPersonAsync(int doctorId, int personId);
    }

    public class DoctorFacade : IDoctorFacade
    {
        private readonly DoctorApiClient _doctorApiClient;
        private readonly PersonApiClient _personApiClient;

        public DoctorFacade()
        {
            _doctorApiClient = new DoctorApiClient();
            _personApiClient = new PersonApiClient();
        }

        public async Task<ApiResult<List<AllDoctorsInfoDTO>>> GetAllDoctorsAsync()
        {
            var result = await _doctorApiClient.GetAllDoctorsAsync();
            return result;
        }

        public async Task<ApiResult<AllDoctorsInfoDTO>> GetDoctorByIdAsync(int doctorId)
        {
            var result = await _doctorApiClient.Find(doctorId);
            return result;
        }

        public async Task<ApiResult<AllDoctorsInfoDTO>> CreateDoctorWithPersonAsync(PersonsDTO personDto, DoctorsDTO doctorDto)
        {
            // Step 1: Add the person to the Person table
            var personResult = await _personApiClient.AddNewPerson(personDto);

            if (!personResult.IsSuccess)
            {
                return new ApiResult<AllDoctorsInfoDTO>
                {
                    IsSuccess = false,
                    Status = personResult.Status,
                    ErrorMessage = personResult.ErrorMessage
                };
            }

            // Step 2: Use the returned PersonId to create the doctor
            doctorDto.PersonId = personResult.Result.Id;
            var doctorResult = await _doctorApiClient.AddNewDoctorAsync(doctorDto);

            if (!doctorResult.IsSuccess)
            {
                return new ApiResult<AllDoctorsInfoDTO>
                {
                    IsSuccess = false,
                    Status = doctorResult.Status,
                    ErrorMessage = doctorResult.ErrorMessage
                };
            }

            // Step 3: Return the combined result
            return new ApiResult<AllDoctorsInfoDTO>
            {
                IsSuccess = true,
                Status = ApiResponseStatus.Success,
                Result = new AllDoctorsInfoDTO(
                    doctorResult.Result.Id,
                    doctorDto.PersonId,
                    doctorDto.Specialization,
                    personDto.PersonName,
                    personDto.DateOfBirth,
                    personDto.Gender,
                    personDto.PhoneNumber,
                    personDto.Email,
                    personDto.Address
                )
            };
        }

        public async Task<ApiResult<AllDoctorsInfoDTO>> UpdateDoctorWithPersonAsync(int doctorId,  PersonsDTO updatedPersonDto, DoctorsDTO updatedDoctorDto)
        {
            
            int personId= updatedPersonDto.Id;
            // Step 1: Update the person details
            var personUpdateResult = await _personApiClient.UpdatePersonInfo(personId, updatedPersonDto);

            if (!personUpdateResult.IsSuccess)
            {
                return new ApiResult<AllDoctorsInfoDTO>
                {
                    IsSuccess = false,
                    Status = personUpdateResult.Status,
                    ErrorMessage = personUpdateResult.ErrorMessage
                };
            }

            // Step 2: Update the doctor details
            updatedDoctorDto.PersonId = personId; // Ensure the PersonId is correctly set
            var doctorUpdateResult = await _doctorApiClient.UpdateDoctorInfo(doctorId, updatedDoctorDto);

            if (!doctorUpdateResult.IsSuccess)
            {
                return new ApiResult<AllDoctorsInfoDTO>
                {
                    IsSuccess = false,
                    Status = doctorUpdateResult.Status,
                    ErrorMessage = doctorUpdateResult.ErrorMessage
                };
            }

            // Step 3: Return the combined result
            return new ApiResult<AllDoctorsInfoDTO>
            {
                IsSuccess = doctorUpdateResult.IsSuccess,
                Status = ApiResponseStatus.Success,
                Result = new AllDoctorsInfoDTO(
                    doctorId,
                    personId,
                    updatedDoctorDto.Specialization,
                    updatedPersonDto.PersonName,
                    updatedPersonDto.DateOfBirth,
                    updatedPersonDto.Gender,
                    updatedPersonDto.PhoneNumber,
                    updatedPersonDto.Email,
                    updatedPersonDto.Address
                )
            };
        }

        public async Task<ApiResult<bool>> DeleteDoctorWithPersonAsync(int doctorId, int personId)
        {
            // Step 1: Delete the doctor
            var doctorDeleteResult = await _doctorApiClient.DeleteDoctor(doctorId);

            if (!doctorDeleteResult.IsSuccess)
            {
                return new ApiResult<bool>
                {
                    IsSuccess = false,
                    Status = doctorDeleteResult.Status,
                    ErrorMessage = doctorDeleteResult.ErrorMessage
                };
            }

            // Step 2: Delete the associated person
            var personDeleteResult = await _personApiClient.DeletePerson(personId);

            if (!personDeleteResult.IsSuccess)
            {
                return new ApiResult<bool>
                {
                    IsSuccess = false,
                    Status = personDeleteResult.Status,
                    ErrorMessage = personDeleteResult.ErrorMessage
                };
            }

            return new ApiResult<bool>
            {
                IsSuccess = true,
                Status = ApiResponseStatus.Success,
                Result = true
            };
        }
    }

}

