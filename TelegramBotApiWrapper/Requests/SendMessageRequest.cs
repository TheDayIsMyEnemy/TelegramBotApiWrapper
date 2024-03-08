using System.Text.Json.Serialization;

namespace TelegramBotApiWrapper.Requests
{
    public class SendMessageRequest
    {
        [JsonPropertyName("chat_id")]
        public long ChatId { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; } = null!;
    }
}