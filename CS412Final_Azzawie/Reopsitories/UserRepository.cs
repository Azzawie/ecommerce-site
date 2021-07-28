using CS412Final_Azzawie.DAL;
using CS412Final_Azzawie.Models;
using CS412Final_Azzawie.Reopsitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Reopsitories
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            return UserDAL.CreateUser(user);
        }

        public User GetUser(string email, string password)
        {
            return UserDAL.GetUser(email, password);
        }

        public bool DoesUserExistByEmail(string email)
        {
            return UserDAL.DoesUserExistByEmail(email);
        }

        public User GetUserById(int userId)
        {
            return UserDAL.GetUserById(userId);
        }
    }
}