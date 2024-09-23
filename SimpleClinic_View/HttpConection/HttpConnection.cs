﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.HttpConection
{
    public sealed class HttpClientSingleton
    {
        private static readonly Lazy<HttpClient> lazyHttpClient =
            new Lazy<HttpClient>(() =>
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5029/api/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                return client;
            });

        public static HttpClient Instance => lazyHttpClient.Value;

        private HttpClientSingleton() { }
    }

}
