﻿

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using SimpleClinic_View.Globals;
using SimpleClinic_View.HttpConection;
using SimpleClinic_View.Patients.Logging;
using SimpleClinic_View.Person.DTOs;
using SimpleClinic_View.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace SimpleClinic_View.Person
{
    public class PersonApiClient
    {
        private static readonly HttpClient _staticHttpClient = HttpClientSingleton.Instance;
        private static string _endPoint = "Persons/";
        public PersonApiClient()
        {
        }
        public async Task<ApiResult<List<PersonsDTO>>> GetAllPeople()
        {
            var apiResult = new ApiResult<List<PersonsDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + "All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var users = await _staticHttpClient.GetFromJsonAsync<List<PersonsDTO>>(_endPoint+"All");
                    apiResult.Result = users;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = ApiResponseStatus.NotFound;
                    // if there is any message in the body 
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                Logger loger = new Logger(LoggingMethod.EventLogger);
                loger.Log($"User Error:{ex.Message}");

            }



            return apiResult;
        }

        public static async Task<ApiResult<PersonsDTO>> StatFind(int PersonID)
        {
            var apiResult = new ApiResult<PersonsDTO>();

            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint+$"Find/{PersonID}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var user = await response.Content.ReadFromJsonAsync<PersonsDTO>();
                    apiResult.Result = user;
                }

                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        _ => ApiResponseStatus.ServerError,
                    };
                    // if there any message in the body will be stored in ErrorMessage
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }


            }
            catch (Exception ex)
            {
                Logger loger = new Logger(LoggingMethod.EventLogger);
                loger.Log($"User Error:{ex.Message}");
            }
            return apiResult;
        }

        public async Task<ApiResult<PersonsDTO>> Find(int PersonID)
        {
            return await StatFind(PersonID);
        }


        public async Task<ApiResult<bool>> ISPersonExist(int PersonID)
        {
            var apiResult = new ApiResult<bool>();

            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint+$"IsExist/{PersonID}");
                if (response.IsSuccessStatusCode)
                {
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = true;
                    apiResult.IsSuccess = true;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Result = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        _ => ApiResponseStatus.ServerError,
                    };
                }
                apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(LoggingMethod.EventLogger);
                logger.Log($"User Error: {ex.Message}");
            }
            return apiResult;
        }



        public async Task<ApiResult<PersonsDTO>> AddNewPerson(PersonsDTO newPerson)
        {
            var apiResult = new ApiResult<PersonsDTO>();
            try
            {
                var response = await _staticHttpClient.PostAsJsonAsync(_endPoint+"Add", newPerson);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Result = await response.Content.ReadFromJsonAsync<PersonsDTO>();
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                }
                else
                {
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.Conflict => ApiResponseStatus.Conflict,
                        _ => ApiResponseStatus.ServerError,

                    };
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Logger logger = new Logger(LoggingMethod.EventLogger);
                logger.Log($"User Error: {ex.Message}");
            }
            return apiResult;
        }

        public async Task<ApiResult<PersonsDTO>> UpdatePersonInfo(int PersonID, PersonsDTO UpdatePerson)
        {


            var apiResult = new ApiResult<PersonsDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint+$"Update/{PersonID}", UpdatePerson);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<PersonsDTO>();

                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.Conflict => ApiResponseStatus.Conflict,
                        _ => ApiResponseStatus.ServerError,

                    };
                    // if there is any error message in the body
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(LoggingMethod.EventLogger);
                logger.Log($"User Error: {ex.Message}");

            }
            return apiResult;
        }

        public async Task<ApiResult<bool>> DeletePerson(int PersonID)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _staticHttpClient.DeleteAsync(_endPoint+$"Delete/{PersonID}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = true;
                    apiResult.IsSuccess = true;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Result = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        _ => ApiResponseStatus.ServerError,
                    };
                }
                apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(LoggingMethod.EventLogger);
                logger.Log($"User Error: {ex.Message}");
            }
            return apiResult;
        }



    }
}
