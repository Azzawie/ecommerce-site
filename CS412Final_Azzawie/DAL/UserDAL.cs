using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Web.Configuration;
using CS412Final_Azzawie.Reopsitories.Interfaces;
using CS412Final_Azzawie.Reopsitories;

namespace CS412Final_Azzawie.DAL
{
    public class UserDAL
    {
        private readonly static IError _error = new Error();
        public static User GetUser(string email, string password)
        {
            User user = null;
            string sql = @"SELECT * FROM users WHERE Email=@Email AND Password=@Password";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    user = new User()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Email = reader.GetString("Email"),
                                        First = reader.GetString("First"),
                                        Last = reader.GetString("Last"),
                                        Password = reader.GetString("Password"),
                                        Phone = reader.GetString("Phone"),
                                        Dob = (DateTime)reader["Dob"]
                                    };
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _error.Log(ex);
                    }
                }
            }
            return user;
        }

        public static User CreateUser(User user)
        {
            string sql = @"INSERT INTO users (First, Last, Email, Phone, Password, Dob) 
                            VALUES
                            (@First, @Last, @Email, @Phone, @Password, @Dob);
                            SELECT LAST_INSERT_ID();";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@First", user.First);
                        cmd.Parameters.AddWithValue("@Last", user.Last);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Phone", user.Phone);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Dob", user.Dob);
                        string o = cmd.ExecuteScalar().ToString();
                        long id = 0;
                        long.TryParse(o, out id);
                        user.Id = id;
                    }
                    catch (Exception ex)
                    {
                        _error.Log(ex);
                        return null;
                    }
                }
            }
            return user;
        }

        public static bool DoesUserExistByEmail(string email)
        {
            bool ret = false;
            string sql = @"SELECT * FROM users WHERE Email=@Email";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            ret = reader.HasRows;
                        }
                    }
                    catch (Exception ex)
                    {
                        _error.Log(ex);
                    }
                }
            }
            return ret;
        }

        public static User GetUserById(int userId)
        {
            User user = null;
            string sql = @"SELECT * FROM users WHERE Id=@Id";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@Id", userId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    user = new User()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Email = reader.GetString("Email"),
                                        First = reader.GetString("First"),
                                        Last = reader.GetString("Last"),
                                        Password = reader.GetString("Password"),
                                        Phone = reader.GetString("Phone"),
                                        Dob = (DateTime)reader["Dob"]
                                    };
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _error.Log(ex);
                    }
                }
            }
            return user;
        }
    }
}