using System.Collections.Generic;
using UsersBook.Domain.Entities;
using UsersBook.Domain.Models;

namespace UsersBook.Domain.Interfaces.Services
{
    public interface IUserService
    {
        IList<User> Get();
        User Get(int id);
        int Create(UserModel user);
        void Update(int id, UserModel user);
        void Delete(int id);
    }
}
