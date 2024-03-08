using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http.Json;
using TelegramBotApiWrapper.Requests;
using TelegramBotApiWrapper.Responses;

namespace TelegramBotApiWrapper
{
    public class TelegramBotApiClient : ITelegramBotApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ITelegramBotApiClientOptions _options;

        public TelegramBotApiClient(
            HttpClient httpClient,
            ITelegramBotApiClientOptions options)
        {
            _httpClient = httpClient;
            _options = options;
        }

        public async Task<GetMeResponse?> GetMe()
        {
            using HttpResponseMessage res = await _httpClient.GetAsync(
                    $"{_options.BaseUrl}/bot{_options.ApiKey}/getMe");

            res.EnsureSuccessStatusCode();

            return await res.Content.ReadFromJsonAsync<GetMeResponse?>();
        }

        public async Task<GetUpdatesResponse?> GetUpdates()
        {
            using HttpResponseMessage res = await _httpClient.GetAsync(
                    $"{_options.BaseUrl}/bot{_options.ApiKey}/getUpdates");

            res.EnsureSuccessStatusCode();

            return await res.Content.ReadFromJsonAsync<GetUpdatesResponse?>();
        }

        public async Task<HttpStatusCode> SendMessage(SendMessageRequest req)
        {
            using StringContent jsonContent = new(
                    JsonSerializer.Serialize(req),
                    Encoding.UTF8,
                    "application/json");

            using HttpResponseMessage res = await _httpClient.PostAsync(
                    $"{_options.BaseUrl}/bot{_options.ApiKey}/sendMessage",
                    jsonContent);

            return res.StatusCode;
        }
    }
}