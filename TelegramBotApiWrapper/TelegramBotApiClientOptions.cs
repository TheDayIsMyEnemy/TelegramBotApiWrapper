namespace TelegramBotApiWrapper
{
    public class TelegramBotApiClientOptions : ITelegramBotApiClientOptions
    {
        public string BaseUrl { get; set; } = "https://api.telegram.org";
        public string ApiKey { get; set; } = null!;
    }
}