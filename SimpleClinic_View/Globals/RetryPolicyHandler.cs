using Polly;
using Polly.CircuitBreaker;
using Polly.Retry;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleClinic_View.Globals
{ 
    // This class handles the retry and circuit breaker policies using Polly
    public class RetryPolicyHandler
    {
        // TEST: Retry policy - Retry up to 1 times with very short backoff
        private static readonly AsyncRetryPolicy<HttpResponseMessage> retryPolicy = Policy
            .Handle<HttpRequestException>()
            .OrResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
            .WaitAndRetryAsync(1, retryAttempt => TimeSpan.FromSeconds(1));// Short delay: 1s, 2s

        // TEST: Circuit Breaker policy - Break after 1 failure for 30 seconds
        private static readonly AsyncCircuitBreakerPolicy<HttpResponseMessage> circuitBreakerPolicy = Policy
            .Handle<HttpRequestException>()
            .OrResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
            .CircuitBreakerAsync(1, TimeSpan.FromSeconds(30)); // Increase the break period to 30 seconds for testing

        // This method wraps an Http request with retry and circuit breaker policies
        public async Task<HttpResponseMessage> ExecuteAsync(Func<Task<HttpResponseMessage>> action)
        {
            return await retryPolicy.ExecuteAsync(() =>
                circuitBreakerPolicy.ExecuteAsync(action)
            );
        }
    }
}


