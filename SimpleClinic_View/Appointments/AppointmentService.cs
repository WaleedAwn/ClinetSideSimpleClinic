﻿using SimpleClinic_View.Globals;
using SimpleClinic_View.Appointments.DTOs;
using SimpleClinic_View.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using SimpleClinic_View.Patients.Logging;
using SimpleClinic_View.HttpConection;

namespace SimpleClinic_View.Appointments
{
    public class AppointmentService
    {

        // Singleton HttpClient instance for static methods
        private static readonly HttpClient _staticHttpClient = HttpClientSingleton.Instance;
        private static string _endPoint = "AppointmentApi/";
        enum enMode { Add = 1, Update = 2 }
        enMode _Mode = enMode.Add;

        public enum enAppointmentStatus { New =1, Cancelled =2, Waiting=3, Completed=4}

        private enAppointmentStatus _appointmentStatus = enAppointmentStatus.New;

        public enAppointmentStatus AppointmentStatus
        {
            get
            {
                switch (_apiResult.Result.AppointmentStatus)
                {
                    case "New":
                        return enAppointmentStatus.New;

                    case "Cancelled":
                       return enAppointmentStatus.Cancelled;
                    case "Waiting":
                        return enAppointmentStatus.Waiting;
                    case "Completed":
                        return enAppointmentStatus.Completed;
                        
                }
                return _appointmentStatus;
            }
            
        }

        public AppointmentService()
        {
            _Mode = enMode.Add;
            _appointmentStatus = enAppointmentStatus.New;
        }

        
        private AppointmentDTO _appointmentDTO
        {
            get { return new AppointmentDTO(_apiResult.Result.Id, _apiResult.Result.PatientId, _apiResult.Result.DoctorId, _apiResult.Result.AppointmentDate,(byte)AppointmentStatus, _apiResult.Result.MedicalRecordId, _apiResult.Result.PaymentId); }
        }

        public AppointmentDTO AppointmentDto
        {
            get
            {
                return _appointmentDTO;
            }
        }

        private ApiResult<AllAppointmentDTO> _apiResult;
        public ApiResult<AllAppointmentDTO> ApiResult
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
        
        private int _appointmentId = -1;

        public int AppointmentId
        {
            get
            {
                return _appointmentId;
            }
        }

        private AppointmentService(int appointmentId, ApiResult<AllAppointmentDTO> apiResult)
        {
            _apiResult = apiResult;
            
            this._appointmentId = appointmentId;
            _Mode = enMode.Update;

        }

        private async Task<bool> _AddNew()
        {
            this._appointmentId = await AddAppointment(this._appointmentDTO);

            return this._appointmentId != -1;
        }
        private async Task<bool> _Update()
        {
            return await UpdateAppointment(_appointmentId, this._appointmentDTO);
        }


        public async Task<ApiResult<List<AllAppointmentDTO>>> GetAllAppointments()
        {
            var apiResult = new ApiResult<List<AllAppointmentDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint+"All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var Appointments = await _staticHttpClient.GetFromJsonAsync<List<AllAppointmentDTO>>(_endPoint+"All");
                    apiResult.Result = Appointments;

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
                loger.Log($"Appointment Error:{ex.Message}");

            }


            return apiResult;
        }

        public async Task<ApiResult<List<AllAppointmentDTO>>> GetAllPatientAppointments(int patientId)
        {
            var apiResult = new ApiResult<List<AllAppointmentDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint+$"All/PatientId={patientId}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var Appointments = await _staticHttpClient.GetFromJsonAsync<List<AllAppointmentDTO>>(_endPoint + $"All/PatientId={patientId}");
                    apiResult.Result = Appointments;

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
                loger.Log($"Appointment Error:{ex.Message}");

            }


            return apiResult;
        }

        public async Task<AppointmentService> Find(int Id)
        {
            return await StatFind(Id);

        }

        public static async Task<AppointmentService> StatFind(int Id)
        {
            var apiResult = new ApiResult<AllAppointmentDTO>();
            int AppointmentId = -1;
            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint+$"Find/Id={Id}");
                
                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                    var Appointment = await response.Content.ReadFromJsonAsync<AllAppointmentDTO>();
                    apiResult.Result = Appointment;
                    AppointmentId = Appointment.Id;

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
                loger.Log($"Appointment Error:{ex.Message}");
            }


            return new AppointmentService(AppointmentId, apiResult);

        }

        public static async Task<ApiResult<int>> GetAppointmentIdByPaymentId(int Id)
        {
            var apiResult = new ApiResult<int>();
            

            try
            {

                var response = await _staticHttpClient.GetAsync(_endPoint+$"Find/PaymentId={Id}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                    var AppointmentId = await response.Content.ReadFromJsonAsync<int>();
                    apiResult.Result = AppointmentId;

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
                loger.Log($"Appointment Error:{ex.Message}");
            }


            return apiResult;

        }


        public async Task<int> AddAppointment(AppointmentDTO newAppointmentDTO)
        {
            var apiResult = new ApiResult<AppointmentDTO>();
            apiResult.Result = new AppointmentDTO();
            apiResult.Result.Id = -1;

            try
            {
                var response = await _staticHttpClient.PostAsJsonAsync(_endPoint+"Add", newAppointmentDTO);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Result = await response.Content.ReadFromJsonAsync<AppointmentDTO>();

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
                logger.Log($"Appointment Error: {ex.Message}");
            }
            _apiResult.ErrorMessage = apiResult.ErrorMessage;

            return apiResult.Result.Id;
        }

        public static async Task<ApiResult<bool>> DeleteAppointment(int AppointmentId)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _staticHttpClient.DeleteAsync(_endPoint+$"Delete/Id={AppointmentId}");

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
                        System.Net.HttpStatusCode.Conflict => ApiResponseStatus.Conflict,

                        _ => ApiResponseStatus.ServerError,
                    };
                }
                apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(LoggingMethod.EventLogger);
                logger.Log($"Appointment Error: {ex.Message}");
            }
            return apiResult;
        }

        public async Task<bool> UpdateAppointment(int AppointmentId, AppointmentDTO updatedAppointment)
        {
            var apiResult = new ApiResult<AppointmentDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint+$"Update/Id={AppointmentId}", updatedAppointment);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<AppointmentDTO>();

                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        _ => ApiResponseStatus.ServerError,

                    };
                    // if there is any error message in the body
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(LoggingMethod.EventLogger);
                logger.Log($"Appointment Error: {ex.Message}");

            }
            _apiResult.ErrorMessage = apiResult.ErrorMessage;

            return apiResult.IsSuccess;
        }


        private async Task<bool> UpdateAppointmentStatus(int AppointmentId, byte status)
        {
            var apiResult = new ApiResult<bool>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint+$"UpdateStatus/Id={AppointmentId}/Status={status}","");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Result = true;
                    apiResult.Status = ApiResponseStatus.Success;

                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        _ => ApiResponseStatus.ServerError,

                    };
                    // if there is any error message in the body
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                Logger logger = new Logger(LoggingMethod.EventLogger);
                logger.Log($"Appointment Error: {ex.Message}");

            }
            _apiResult.ErrorMessage = apiResult.ErrorMessage;

            return apiResult.IsSuccess;
        }

        public async Task<bool> Cancel()
        {
            return await UpdateAppointmentStatus(this.AppointmentId, 2);
        }

        public async Task<bool> SetComplete()
        {
            return await UpdateAppointmentStatus(this.AppointmentId, 4);
        }

        public async Task<bool> SetWaiting()
        {
            return await UpdateAppointmentStatus(this.AppointmentId, 3);
        }

        public async Task<ApiResult<int>> GetAppointmentsNumber()
        {
            var apiResult = new ApiResult<int>();

            try
            {

                var response = await _httpClient.GetAsync($"CountNumber");
                if (response.IsSuccessStatusCode)
                {
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<int>();
                    apiResult.IsSuccess = true;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Result = -1;
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


        public async Task<bool> Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        //_Mode = enMode.Update;
                        if (await _AddNew())
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

