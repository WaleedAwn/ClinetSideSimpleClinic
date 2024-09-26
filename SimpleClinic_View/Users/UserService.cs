using SimpleClinic_View.Globals;
using SimpleClinic_View.Users.DTOs;
using SimpleClinic_View.HttpConection;
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
using SimpleClinic_View.Patients.Logging;

namespace SimpleClinic_View.Users
{
    public class UserService
    {

        private static readonly HttpClient _staticHttpClient =  HttpClientSingleton.Instance ;

        enum enMode { Add =1, Update = 2}
        enMode _Mode = enMode.Add;

        static string _endPoint = "UserApi/";
        public UserService()
        {
            _Mode = enMode.Add;
        }
        

        private UserDTO UserDTO
        {            
            get { return new UserDTO(_apiResult.Result.Id, _apiResult.Result.PersonId, _apiResult.Result.UserName, _apiResult.Result.Password); }
        }

        private ApiResult<AllUserDTO> _apiResult;
        public ApiResult<AllUserDTO> ApiResult
        { 
            get
            {
                return _apiResult;
            }
            set
            {
                _apiResult = value;
                
            }
        }
        private int _userId = -1;

        public int UserId
        {
            get
            {
                return _userId;
            }
        }

        private UserService(int userId, ApiResult<AllUserDTO> apiResult)
        {
            _apiResult = apiResult;
            this._userId = userId;
            _Mode = enMode.Update;

        }

        private async Task<bool> _AddNew()
        {
            this._userId = await AddUser(this.UserDTO);
            
            return this._userId != -1;
        }
        private async Task<bool> _Update()
        {                       
            return await UpdateUser(_userId, this.UserDTO);
        }

        public  async Task<ApiResult<List<AllUserDTO>>> GetAllUsers()
        {
            var apiResult = new ApiResult<List<AllUserDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint+"All");

                if(response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var users = await _staticHttpClient.GetFromJsonAsync<List<AllUserDTO>>(_endPoint+"All");
                    apiResult.Result = users;

                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = ApiResponseStatus.NotFound;
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
        
        public  async Task<UserService> Find(int Id)
        {
            return await StatFind(Id);            
        }       
        
        public static async Task<UserService> StatFind(int Id)
        {
            var apiResult = new ApiResult<AllUserDTO>();
            int userId = -1;
            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint+"Find/Id={Id}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                    var user = await response.Content.ReadFromJsonAsync<AllUserDTO>();
                    apiResult.Result = user;
                    userId = user.Id;

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

            
                return new UserService(userId, apiResult);
            
        }


        public async Task<ApiResult<AllUserDTO>> Find(string userName)
        {
            var apiResult = new ApiResult<AllUserDTO>();

            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint+$"Find/UserName={userName}");

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
        
        public  async Task<int> AddUser(UserDTO newUserDTO)
        {
            var apiResult = new ApiResult<UserDTO>();
            apiResult.Result = new UserDTO();
            apiResult.Result.Id = -1;

            try
            {
                var response = await _staticHttpClient.PostAsJsonAsync(_endPoint+"Add", newUserDTO);

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
            _apiResult.ErrorMessage = apiResult.ErrorMessage;

            return apiResult.Result.Id;
        }
        
        public  async Task<ApiResult<bool>> DeleteUser(int UserId)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _staticHttpClient.DeleteAsync(_endPoint+$"Delete/Id={UserId}");

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
        
        public  async Task<bool> UpdateUser(int UserId, UserDTO updatedUser)
        {
            var apiResult = new ApiResult<UserDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint+$"Update/Id={UserId}", updatedUser);

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
            _apiResult.ErrorMessage = apiResult.ErrorMessage;

            return apiResult.IsSuccess;
        }
      
        public static async Task<ApiResult<bool>> CheckCredentials(string userName, string password)
        {
            var apiResult = new ApiResult<bool>();
            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint+$"CheckCredentials/UserName={userName}/Password{password}");

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

        public static async Task<bool> IsUserExist(string userName)
        {
            var apiResult = new ApiResult<bool>();
            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint + $"IsUserExists/UserName={userName}");

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
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,

                        _ => ApiResponseStatus.ServerError,

                    };
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                Logger loger = new Logger(LoggingMethod.EventLogger);
                loger.Log($"User Error:{ex.Message}");
            }
            return apiResult.Result;
        }

        public static async Task<bool> IsPersonUser(int id)
        {
            var apiResult = new ApiResult<bool>();
            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint + $"IsPersonUser/PersonId/{id}");

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
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,

                        _ => ApiResponseStatus.ServerError,

                    };
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                Logger loger = new Logger(LoggingMethod.EventLogger);
                loger.Log($"User Error:{ex.Message}");
            }
            return apiResult.Result;
        }


        public async Task<bool> Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    {
                        //_Mode = enMode.Update;
                        if(await _AddNew())
                        {
                            _Mode = enMode.Update;

                            return true;
                        }

                        return false;
                    }
                    
                case enMode.Update:
                    {
                        return await _Update();
                    }
                    
            }
            return false;
        }

    }
}
