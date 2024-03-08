using System.Text.Json.Serialization;

namespace TelegramBotApiWrapper.Responses
{
    public class GetUpdatesResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("result")]
        public List<GetUpdatesResult> Result { get; set; } = null!;
    }

    public class Chat
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = null!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;

        [JsonPropertyName("all_members_are_administrators")]
        public bool AllMembersAreAdministrators { get; set; }
    }

    public class From
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("is_bot")]
        public bool IsBot { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = null!;

        [JsonPropertyName("language_code")]
        public string LanguageCode { get; set; } = null!;
    }

    public class Message
    {
        [JsonPropertyName("message_id")]
        public long? MessageId { get; set; }

        [JsonPropertyName("from")]
        public From From { get; set; } = null!;

        [JsonPropertyName("chat")]
        public Chat Chat { get; set; } = null!;

        [JsonPropertyName("date")]
        public int? Date { get; set; }

        [JsonPropertyName("group_chat_created")]
        public bool? GroupChatCreated { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; } = null!;
    }

    public class MyChatMember
    {
        [JsonPropertyName("chat")]
        public Chat Chat { get; set; } = null!;

        [JsonPropertyName("from")]
        public From From { get; set; } = null!;

        [JsonPropertyName("date")]
        public int? Date { get; set; }

        [JsonPropertyName("old_chat_member")]
        public OldChatMember OldChatMember { get; set; } = null!;

        [JsonPropertyName("new_chat_member")]
        public NewChatMember NewChatMember { get; set; } = null!;
    }

    public class NewChatMember
    {
        [JsonPropertyName("user")]
        public User User { get; set; } = null!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = null!;
    }

    public class OldChatMember
    {
        [JsonPropertyName("user")]
        public User User { get; set; } = null!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = null!;
    }

    public class GetUpdatesResult
    {
        [JsonPropertyName("update_id")]
        public int? UpdateId { get; set; }

        [JsonPropertyName("my_chat_member")]
        public MyChatMember MyChatMember { get; set; } = null!;

        [JsonPropertyName("message")]
        public Message Message { get; set; } = null!;
    }

    public class User
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("is_bot")]
        public bool IsBot { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = null!;

        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;
    }
}