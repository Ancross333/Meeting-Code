using Domain.User;
using MediatR;

namespace Api.Commands
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, AddUserDto>
    {
        private readonly IUserRepository _userRepository;
        public AddUserCommandHandler(IUserRepository userRepo ) => _userRepository = userRepo;
        public Task<AddUserDto> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return HandleInternalAsync(request);
        }

        public async Task<AddUserDto> HandleInternalAsync(AddUserCommand request)
        {
            var user = new User(request.Username, request.Password, request.Email);
            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return new AddUserDto
            {
                UserId = user.Id,
            };
        }
    }
}
