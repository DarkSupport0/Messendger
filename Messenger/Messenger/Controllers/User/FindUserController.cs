using Messenger.SQL.CQRS.User.Query.FindUser;
using Messenger.SQL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.User
{
    [ApiController]
    [Route("users")]
    [ApiExplorerSettings(GroupName = "users")]
    public class FindUserController : ControllerBase
    {
        private readonly IFindUserQueryHandler _query;

        public FindUserController(IFindUserQueryHandler query)
        {
            _query = query;
        }

        [HttpPost("find")]
        public async Task<FindUserDto?> Find(string username)
        {
            return await _query.Handle(new FindUserQuery(username));
        }
    }
}