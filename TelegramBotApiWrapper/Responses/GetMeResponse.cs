using System.Text.Json.Serialization;

namespace TelegramBotApiWrapper.Responses
{
    public class GetMeResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("result")]
        public GetMeResult Result { get; set; } = null!;
    }

    public class GetMeResult
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("is_bot")]
        public bool IsBot { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = null!;

        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;

        [JsonPropertyName("can_join_groups")]
        public bool CanJoinGroups { get; set; }

        [JsonPropertyName("can_read_all_group_messages")]
        public bool CanReadAllGroupMessages { get; set; }

        [JsonPropertyName("supports_inline_queries")]
        public bool SupportsInlineQueries { get; set; }
    }
}