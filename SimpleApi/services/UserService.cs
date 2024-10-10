using BlogApp.Data;
using BlogApp.Models;

namespace BlogApp.Services
{
    public class UserService(BlogAppDbContext dbContext)
    {
        private readonly BlogAppDbContext _dbContext = dbContext;

        public async Task CreateUserAsync(string name)
        {
            var user = new User { Name = name };

            // Add user to the database context
            _dbContext.User.Add(user);

            // Save changes to the database
            await _dbContext.SaveChangesAsync();
        }
    }
}
