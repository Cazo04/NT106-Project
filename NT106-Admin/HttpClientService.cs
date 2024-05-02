using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NT106_Admin
{
    public class HttpClientService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUri;        

        public HttpClientService(string accessToken = "None", string baseUri = "https://localhost:7204")
        {
            if (Storage.TempToken != null && accessToken == "None")
            {
                accessToken = Storage.TempToken;
            }
            _baseUri = baseUri;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUri)
            };
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        public async Task<string> GetAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                //response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return $"Error: {response.StatusCode} - {errorContent}";
                }
            }
            catch (HttpRequestException e)
            {
                return $"Network or server error occurred: {e.Message}";
            }
        }

        public async Task<string> PostAsync(string url, string jsonString)
        {
            try
            {
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return $"Error: {response.StatusCode} - {errorContent}";
                }
            }
            catch (HttpRequestException e)
            {
                return $"Network or server error occurred: {e.Message}";
            }
        }
    }
}
