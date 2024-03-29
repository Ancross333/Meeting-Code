using Db;
using Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly ExampleDbContext _dbContext;

        public UserRepository(ExampleDbContext dbContext) 
        {
          _dbContext = dbContext;
        }
        public async Task AddAsync(User user) => await _dbContext.User.AddAsync(user);

        public User? Get(int userId)
        {
            return _dbContext.User.Where(x => x.Id == userId).FirstOrDefault();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        
    }
}
