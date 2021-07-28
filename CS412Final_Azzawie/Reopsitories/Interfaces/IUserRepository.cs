using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Reopsitories.Interfaces
{
    interface IUserRepository
    {
        User GetUser(string email, string password);
        User CreateUser(User user);
        bool DoesUserExistByEmail(string email);
        User GetUserById(int userId);
    }
}