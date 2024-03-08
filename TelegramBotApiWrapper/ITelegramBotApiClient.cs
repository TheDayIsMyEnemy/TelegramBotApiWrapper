using System.Net;
using TelegramBotApiWrapper.Requests;
using TelegramBotApiWrapper.Responses;

namespace TelegramBotApiWrapper
{
    public interface ITelegramBotApiClient
    {
        public Task<GetMeResponse?> GetMe();
        public Task<GetUpdatesResponse?> GetUpdates();
        public Task<HttpStatusCode> SendMessage(SendMessageRequest request);
    }
}