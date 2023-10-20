using Messenger.PostgreSQL.Commands.BlackList.Add;
using Microsoft.AspNetCore.Mvc;
using Messenger.RestModels.BlackList;

namespace Messenger.Controllers.BlackList;

[ApiController]
[Route("Chat")]
[ApiExplorerSettings(GroupName = "Chat")]
public sealed class AddBlackListController : ControllerBase
{
    private readonly IAddBlackListCommand _blackList;

    public AddBlackListController(IAddBlackListCommand blackList)
    {
        _blackList = blackList;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] AddBlasckListRequest request)
    {
        // validate user
        // handle user validation result

        AddBlackListDto dto = new AddBlackListDto();
        await _blackList.Execute(dto);

        return Ok();
    }
}