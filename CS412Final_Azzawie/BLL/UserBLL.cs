using CS412Final_Azzawie.BLL.Interfaces;
using CS412Final_Azzawie.Models;
using CS412Final_Azzawie.Reopsitories;
using CS412Final_Azzawie.Reopsitories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.BLL
{
    public class UserBLL : IUserBLL
    {
        private readonly IUserRepository _userRepository;
        public UserBLL()
        {
            _userRepository = new UserRepository();
        }

        public User CreateUser(User user)
        {
            if (_userRepository.DoesUserExistByEmail(user.Email) == false)
            {
                return _userRepository.CreateUser(user);
            }
            return null;
        }

        public User GetUser(string email, string password)
        {
            return _userRepository.GetUser(email, password);
        }
    }
}