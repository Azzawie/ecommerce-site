using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.BLL.Interfaces
{
    interface IUserBLL
    {
        User GetUser(string email, string password);
        User CreateUser(User user);
    }
}