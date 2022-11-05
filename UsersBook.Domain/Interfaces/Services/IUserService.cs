﻿using System.Collections.Generic;
using UsersBook.Domain.Entities;

namespace UsersBook.Domain.Interfaces.Services
{
    public interface IUserService
    {
        IList<User> Get();
        User Get(int id);
        int Create(User user);
        void Update(int id, User user);
        void Delete(int id);
    }
}
