﻿using SimpleClinic_View.Doctors.DTOs;
using SimpleClinic_View.Globals;
using SimpleClinic_View.HttpConection;
using SimpleClinic_View.Patients.DTOs;
using SimpleClinic_View.Patients.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Doctors
{
    public class DoctorApiClient
    {

        private static readonly HttpClient _staticHttpClient = HttpClientSingleton.Instance;
        private static string _endPoint = "Doctor/";
        public DoctorApiClient()
        {

        }


        public static async Task<ApiResult<List<AllDoctorsInfoDTO>>> GetAllDoctors()
        {
            var apiResult = new ApiResult<List<AllDoctorsInfoDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint+"All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var users = await _staticHttpClient.GetFromJsonAsync<List<AllDoctorsInfoDTO>>(_endPoint + "All");
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


        public async Task<ApiResult<List<AllDoctorsInfoDTO>>> GetAllDoctorsAsync()
        {        
            return await GetAllDoctors();
        }

        public static async Task<ApiResult<AllDoctorsInfoDTO>> StatFind(int DoctorID)
        {
            var apiResult = new ApiResult<AllDoctorsInfoDTO>();

            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint+$"Find/{DoctorID}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var user = await response.Content.ReadFromJsonAsync<AllDoctorsInfoDTO>();
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


        public async Task<ApiResult<AllDoctorsInfoDTO>> Find(int DoctorID)
        {
           return await StatFind(DoctorID);
        }


        public async Task<ApiResult<DoctorsDTO>> AddNewDoctorAsync(DoctorsDTO newDoctor)
        {
            var apiResult = new ApiResult<DoctorsDTO>();
            try
            {
                var response = await _staticHttpClient.PostAsJsonAsync(_endPoint + "Add", newDoctor);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Result = await response.Content.ReadFromJsonAsync<DoctorsDTO>();
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

        public async Task<ApiResult<DoctorsDTO>> UpdateDoctorInfo(int DoctorID, DoctorsDTO UpdateDoctor)
        {


            var apiResult = new ApiResult<DoctorsDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint + $"Update/{DoctorID}", UpdateDoctor);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<DoctorsDTO>();

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

        public async Task<ApiResult<bool>> DeleteDoctor(int DoctorId)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _staticHttpClient.DeleteAsync(_endPoint + $"Delete/{DoctorId}");

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
