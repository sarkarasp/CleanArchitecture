﻿using OA.DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.ServiceLayer
{
   public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}
