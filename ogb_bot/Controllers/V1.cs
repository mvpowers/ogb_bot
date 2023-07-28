using Microsoft.AspNetCore.Mvc;
using ogb_bot.Data;
using ogb_bot.Services;

namespace ogb_bot.Controllers;

[ApiController]
[Route("[controller]")]
public class V1Controller : ControllerBase
{
    private readonly ILogger<V1Controller> _logger;
    private readonly IGroupMeCallBackService _groupMeCallBackService;

    public V1Controller(ILogger<V1Controller> logger, IGroupMeCallBackService groupMeCallBackService)
    {
        _logger = logger;
        _groupMeCallBackService = groupMeCallBackService;
    }

    [HttpPost]
    public IActionResult GroupMeCallback(GroupMeCallback req)
    {
        try
        {
            var result = _groupMeCallBackService.HandleGroupMeCallback(req);
            _logger.LogInformation(result);
            return Ok(result);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}