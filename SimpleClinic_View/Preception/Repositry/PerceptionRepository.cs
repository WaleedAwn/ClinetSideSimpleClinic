using SimpleClinic_View.Preception.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SimpleClinic_View.HttpConection;

namespace SimpleClinic_View.Preception.Repositry
{
 

    public class PerceptionRepository<T> : IRepository<PerceptionDTO>
    {
        private readonly HttpClient _httpClient;
        private readonly string _endPoint;
        public PerceptionRepository(string endPoint) 
        {
        _httpClient= HttpClientSingleton.Instance;
            _endPoint = endPoint;
        }

        // Add Perception
        public async Task<int> AddAsync(PerceptionDTO perception)
        {
            var response = await _httpClient.PostAsJsonAsync(_endPoint + "Add", perception);
            if (response.IsSuccessStatusCode)
            {
                var createdPerception = await response.Content.ReadFromJsonAsync<PerceptionDTO>();
                return createdPerception?.PrescriptionID ?? 0;
            }
            return -1;
        }

        // Get All Perceptions
        public async Task<List<PerceptionDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(_endPoint+"All");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<PerceptionDTO>>() ?? new List<PerceptionDTO>();
            }
            return new List<PerceptionDTO>();
        }

        // Get Perception by ID
        public async Task<PerceptionDTO> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync(_endPoint + $"Find/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<PerceptionDTO>();
            }
            return null;
        }

        // Update Perception
        public async Task<bool> UpdateAsync(int id, PerceptionDTO perception)
        {
            var response = await _httpClient.PutAsJsonAsync(_endPoint + $"Update/{id}", perception);
            return response.IsSuccessStatusCode;
        }

        // Delete Perception
        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync(_endPoint + $"Delete/{id}");
            return response.IsSuccessStatusCode;
        }
    }

}
