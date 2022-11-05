using System;
using System.Collections.Generic;
using UsersBook.Domain.Entities;
using UsersBook.Domain.ExtensionMethods;
using UsersBook.Domain.Interfaces.Repositories;
using UsersBook.Domain.Interfaces.Services;

namespace UsersBook.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public IList<User> Get()
        {
            var users = _repository.Get();

            return users;
        }

        public User Get(int id)
        {
            return _repository.Get(id);
        }

        public int Create(User user)
        {
            if (!user.Email.IsValid())
                throw new ArgumentException("Invalid Email!");

            return _repository.Create(user);
        }

        public void Update(int id, User user)
        {
            user.Id = id;

            if (!user.Email.IsValid())
                throw new ArgumentException("Invalid Email!");

            _repository.Update(user);
        }

        public void Delete(int id)
        {
            var user = _repository.Get(id);

            if (user is null)
                return;

            _repository.Delete(user);
        }
    }
}
