using System.Collections.Generic;
using UsersBook.Domain.Entities;

namespace UsersBook.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        IList<User> Get();
        User Get(int id);
        int Create(User user);
        void Update(User user);
        void Delete(User user);
    }
}
