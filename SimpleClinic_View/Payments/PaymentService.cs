using SimpleClinic_View.Globals;
using SimpleClinic_View.Patients.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using SimpleClinic_View.Payments.DTOs;

namespace SimpleClinic_View.Payments
{
    internal class PaymentService
    {
        

        // Singleton HttpClient instance for static methods
        private static readonly HttpClient _staticHttpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5029/api/PaymentApi/") };
        enum enMode { Add = 1, Update = 2 }
        enMode _Mode = enMode.Add;



        public PaymentService()
        {
            _Mode = enMode.Add;            
        }


        private PaymentDTO _paymentDto
        {
            get
            {
                return new PaymentDTO(_apiPaymentResult.Result.Id, _apiPaymentResult.Result.PaymentDate, _apiPaymentResult.Result.PaymentMethodId, _apiPaymentResult.Result.AmountPaid, _apiPaymentResult.Result.AdditionalNotes);
            }
        }

        public PaymentDTO PaymentDto
        {
            get
            {
                return _paymentDto;
            }
        }

        private ApiResult<PaymentDTOWithName> _apiPaymentResult;
        public ApiResult<PaymentDTOWithName> ApiPaymentResult
        {
            get
            {
                return _apiPaymentResult;
            }
            set
            {
                _apiPaymentResult = value;

            }
        }

        private int _paymentId = -1;

        public int PaymentId
        {
            get
            {
                return _paymentId;
            }
        }

        private PaymentService(int paymentId, ApiResult<PaymentDTOWithName> apiResult)
        {
            _apiPaymentResult = apiResult;

            this._paymentId = paymentId;
            _Mode = enMode.Update;
        }

        private async Task<bool> _AddNew()
        {
            this._paymentId = await AddPayment(this._paymentDto);

            return this._paymentId != -1;
        }
        private async Task<bool> _Update()
        {
            return await UpdatePayment(_paymentId, this._paymentDto);
        }


        public async Task<ApiResult<List<PaymentDTOWithName>>> GetAllPaymentsAsync()
        {
            var apiResult = new ApiResult<List<PaymentDTOWithName>>();
            try
            {
                var response = await _staticHttpClient.GetAsync("All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var Appointments = await _staticHttpClient.GetFromJsonAsync<List<PaymentDTOWithName>>("All");
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
                loger.Log($"Payment Error:{ex.Message}");

            }


            return apiResult;
        }

        public static async Task<ApiResult<List<PaymentMethodDTO>>> GetAllPaymentMethodsAsync()
        {
            var apiResult = new ApiResult<List<PaymentMethodDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync("All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var Appointments = await _staticHttpClient.GetFromJsonAsync<List<PaymentMethodDTO>>("PaymentMethods");
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
                loger.Log($"Payment Error:{ex.Message}");

            }


            return apiResult;
        }


        public async Task<PaymentService> Find(int Id)
        {
            return await StatFind(Id);

        }

        public static async Task<PaymentService> StatFind(int Id)
        {
            var apiResult = new ApiResult<PaymentDTOWithName>();
            int paymentId = -1;
            try
            {

                var response = await _staticHttpClient.GetAsync($"Find/Id={Id}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;

                    var payment = await response.Content.ReadFromJsonAsync<PaymentDTOWithName>();
                    apiResult.Result = payment;
                    paymentId = payment.Id;

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
                loger.Log($"Payment Error:{ex.Message}");
            }


            return new PaymentService(paymentId, apiResult);

        }



        public async Task<int> AddPayment(PaymentDTO newPaymentDto)
        {
            var apiResult = new ApiResult<PaymentDTO>();
            apiResult.Result = new PaymentDTO();
            apiResult.Result.Id = -1;

            try
            {
                var response = await _staticHttpClient.PostAsJsonAsync("Add", newPaymentDto);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.Result = await response.Content.ReadFromJsonAsync<PaymentDTO>();

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
                logger.Log($"Payment Error: {ex.Message}");
            }
            _apiPaymentResult.ErrorMessage = apiResult.ErrorMessage;

            return apiResult.Result.Id;
        }

        public static async Task<ApiResult<bool>> DeleteAppointment(int paymentId)
        {
            var apiResult = new ApiResult<bool>();

            try
            {
                var response = await _staticHttpClient.DeleteAsync($"Delete/Id={paymentId}");

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
                logger.Log($"Payment Error: {ex.Message}");
            }
            return apiResult;
        }

        public async Task<bool> UpdatePayment(int paymentId, PaymentDTO updatedPayment)
        {
            var apiResult = new ApiResult<PaymentDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync($"Update/Id={paymentId}", updatedPayment);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<PaymentDTO>();

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
                logger.Log($"Payment Error: {ex.Message}");

            }
            _apiPaymentResult.ErrorMessage = apiResult.ErrorMessage;

            return apiResult.IsSuccess;
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
