using System.Collections.Generic;
using System.Linq;
using UsersBook.Domain.Entities;
using UsersBook.Domain.Interfaces.Repositories;
using UsersBook.Infrastructure.Context;

namespace UsersBook.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IList<User> Get()
        {
            return _context.Users?.ToList();
        }

        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public int Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user.Id;
        }

        public void Update(User user)
        {
            var originalUser = _context.Users.Find(user.Id);

            if (originalUser is null)
                throw new KeyNotFoundException("User not found!");

            _context.Entry(originalUser).CurrentValues.SetValues(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
