using System.Text.Json;
using ogb_bot.Data;

namespace ogb_bot.Services;

public interface IGroupMeCallBackService
{
    public string HandleGroupMeCallback(GroupMeCallback req);   
}

public class GroupMeCallBackService : IGroupMeCallBackService
{
    public string HandleGroupMeCallback(GroupMeCallback req)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        return JsonSerializer.Serialize(req, options);
    }
}