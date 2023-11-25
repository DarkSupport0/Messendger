using Messenger.SQL.CQRS.User.Query.FindUserById;
using Messenger.SQL.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.User
{
    [ApiController]
    [Route("users")]
    [ApiExplorerSettings(GroupName = "users")]
    public class FindUserbyIdController : ControllerBase
    {
        private readonly IFindUserByIdQueryHandler _query;

        public FindUserbyIdController(IFindUserByIdQueryHandler query)
        {
            _query = query;
        }

        [HttpPost("findbyid")]
        public async Task<FindUserDto?> Find(int id)
        {
            return await _query.Handle(new FindUserQueryById(id));
        }
    }
}
