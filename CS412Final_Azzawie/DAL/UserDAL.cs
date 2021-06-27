using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.DAL
{
    public class UserDAL
    {
        // We will use fake users for now until we connect to a database
        private static List<User> _users = new List<User>() {
            new User()
                    {   
                        Id = 1,
                        First = "Mustafa",
                        Last = "Azzawie",
                        Email = "mmakialazzaw@neiu.edu",
                        Password = "12345678"
                    },
                        new User()
                    {
                        Id = 2,
                        First = "Chris",
                        Last = "Chris_last",
                        Email = "Chris@gmail.com",
                        Password = "12345678"
                    },
                        new User()
                    {
                        Id = 3,
                        First = "Greg",
                        Last = "Greg_last",
                        Email = "Greg@gmail.com",
                        Password = "12345678"
                    }
    };

        // SQL query to retrieve a user from the database
        public static User GetUser(string email, string password)
        {
            return _users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        // SQL query to insert a new user into the database and return it back
        public static User CreateUser(User user)
        {
            User lastUser = _users.LastOrDefault();
            user.Id = lastUser.Id + 1;
            _users.Add(user);
            return user;
        }
    }
}