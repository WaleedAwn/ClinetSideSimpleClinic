using SimpleClinic_View.Globals;
using SimpleClinic_View.Logging;
using SimpleClinic_View.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SimpleClinic_View.Users
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        // Singleton HttpClient instance for static methods
        private static readonly HttpClient _staticHttpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5029/api/UserApi/") };


        public UserService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5029/api/UserApi/");
        }

        public  async Task<ApiResult<List<AllUserDTO>>> GetAllUsers()
        {
            var apiResult = new ApiResult<List<AllUserDTO>>();
            try
            {
                var response = await _httpClient.GetAsync("All");

                if(response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var users = await _httpClient.GetFromJsonAsync<List<AllUserDTO>>("All");
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
        
        public  async Task<ApiResult<AllUserDTO>> Find(int Id)
        {
            return await StatFind(Id);

            //var apiResult = new ApiResult<AllUserDTO>();

            //try
            //{

            //    var response = await _httpClient.GetAsync($"Find/Id={Id}");

            //    if (response.IsSuccessStatusCode)
            //    {
            //        apiResult.IsSuccess = true;
            //        apiResult.Status = ApiResponseStatus.Success;
                    
            //        var user = await response.Content.ReadFromJsonAsync<AllUserDTO>();
            //        apiResult.Result = user;
                    

            //    }
                
            //    else
            //    {
            //        apiResult.IsSuccess = false;
            //        apiResult.Status = response.StatusCode switch
            //        {
            //            System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
            //            System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
            //            _=> ApiResponseStatus.ServerError,
            //        };
            //        // if there any message in the body will be stored in ErrorMessage
            //        apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();

            //    }
                

            //}
            //catch (Exception ex)
            //{
            //    Logger loger = new Logger(LoggingMethod.EventLogger);
            //    loger.Log($"User Error:{ex.Message}");
            //}
            //return apiResult;
        }       
        
        public static async Task<ApiResult<AllUserDTO>> StatFind(int Id)
        {
            var apiResult = new ApiResult<AllUserDTO>();

            try
            {

                var response = await _staticHttpClient.GetAsync($"Find/Id={Id}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                    var user = await response.Content.ReadFromJsonAsync<AllUserDTO>();
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


        public async Task<ApiResult<AllUserDTO>> Find(string userName)
        {
            var apiResult = new ApiResult<AllUserDTO>();

            try
            {

                var response = await _httpClient.GetAsync($"Find/UserName={userName}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                    var user = await response.Content.ReadFromJsonAsync<AllUserDTO>();
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
        
        public  async Task<ApiResult<UserDTO>> AddUser(UserDTO newUserDTO)
        {
            var apiResult = new ApiResult<UserDTO>();

            try
            {
                var response = await _httpClient.PostAsJsonAsync("", newUserDTO);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Result = await response.Content.ReadFromJsonAsync<UserDTO>();
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
        
        public  async Task<ApiResult<bool>> DeleteUser(int UserId)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _httpClient.DeleteAsync($"Delete/Id={UserId}");

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
                        _=> ApiResponseStatus.ServerError,
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
        
        public  async Task<ApiResult<UserDTO>> UpdateUser(int UserId, UserDTO updatedUser)
        {
            var apiResult = new ApiResult<UserDTO>();
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"Update/Id={UserId}", updatedUser);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<UserDTO>();

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
      
        public  async Task<ApiResult<bool>> CheckCredentials(string userName, string password)
        {
            var apiResult = new ApiResult<bool>();
            try
            {

                var response = await _httpClient.GetAsync($"CheckCredentials/UserName={userName}/Password{password}");

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
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.Unauthorized => ApiResponseStatus.Unauthorized,
                        _=> ApiResponseStatus.ServerError,

                    };
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

    }
}
