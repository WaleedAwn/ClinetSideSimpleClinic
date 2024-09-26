using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Globals
{
    public sealed class HttpClientSingleton
    {

        // Static readonly instance of HttpClient
        private static readonly Lazy<HttpClient> _httpClientInstance =
            new Lazy<HttpClient>(() =>
            {
                var client = new HttpClient();
                return client;
            });

        // Private constructor to prevent instantiation
        private HttpClientSingleton() { }

        // Public method to access the single instance
        public static HttpClient Instance => _httpClientInstance.Value;


    }
}
