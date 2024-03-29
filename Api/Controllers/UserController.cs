using Api.Commands;
using Api.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMediator _mediator;
        public UserController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [Route("Add")]
        [HttpPost]
        public async Task<ActionResult> AddUser(AddUserRequest request)
        {
            var cmd = new AddUserCommand(request.Name, request.Password, request.Email);

            var data = await _mediator.Send(cmd);

            return Ok(data);
        }
    }
}
