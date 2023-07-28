using System.Text.Json.Serialization;

namespace ogb_bot.Data;

public class GroupMeCallbackAttachment
{
    public string Todo { get; set; } 
}

public class GroupMeCallback
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("system")]
    public bool System { get; set; }
    
    [JsonPropertyName("text")]
    public string Text { get; set; }
    
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }
    
    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }
    
    [JsonPropertyName("created_at")]
    public int CreatedAt { get; set; }
    
    [JsonPropertyName("group_id")]
    public string GroupId { get; set; }
    
    [JsonPropertyName("sender_id")]
    public string SenderId { get; set; }
    
    [JsonPropertyName("sender_type")]
    public string SenderType { get; set; }
    
    [JsonPropertyName("source_guid")]
    public Guid SourceGuid { get; set; }
    
    [JsonPropertyName("attachments")]
    public List<GroupMeCallbackAttachment> Attachments { get; set; } = new();
}