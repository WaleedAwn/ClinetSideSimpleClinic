using SimpleClinic_View.HttpConection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using SimpleClinic_View.MedicalRecords.Repositry;
using System.Net.Http.Json;

namespace SimpleClinic_View.MedicalRecords.Repositry.Repositories
{
    public class ClientRepository<T> : IMedicalRecordRepository<T> where T : class
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiEndpoint;

        public ClientRepository(string apiEndpoint)
        {
            _httpClient = HttpClientSingleton.Instance;
            _apiEndpoint = apiEndpoint;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(_apiEndpoint+"/All");
            response.EnsureSuccessStatusCode();

            // استخدام ReadFromJsonAsync لقراءة محتوى الاستجابة
            var Result= await (response.Content.ReadFromJsonAsync<IEnumerable<T>>());
            return Result??new List<T>();
        }



        public async Task<T?> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync(_apiEndpoint+"/Find/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<bool> AddAsync(T entity)
        {
            var response = await _httpClient.PostAsJsonAsync(_apiEndpoint+"/Add", entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id,T entity)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_apiEndpoint}/Update/{id}", entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_apiEndpoint}/Delete/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
