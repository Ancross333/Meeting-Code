using MediatR;

namespace Api.Commands
{
    public class AddUserCommand : IRequest<AddUserDto>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public AddUserCommand(string username, string password, string email) 
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }

    public record AddUserDto
    {
        public int UserId { get; set; } 
    }
}
