namespace Domain.User
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task SaveChangesAsync();
    }
}
