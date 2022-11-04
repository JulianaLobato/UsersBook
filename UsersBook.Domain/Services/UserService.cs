using System.Collections.Generic;
using UsersBook.Domain.Entities;
using UsersBook.Domain.Interfaces.Repositories;
using UsersBook.Domain.Interfaces.Services;
using UsersBook.Domain.Models;

namespace UsersBook.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUsersBookRepository _repository;

        public UserService(IUsersBookRepository repository)
        {
            _repository = repository;
        }

        public IList<User> Get()
        {
            return new List<User>();
        }

        public User Get(int id)
        {
            return new User();
        }

        public int Create(UserModel user)
        {
            return 1;
        }

        public void Update(int id, UserModel user)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
