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
    public class AdDAL
    {
        private readonly static IError _error = new Error();

        public static List<Ad> GetAds()
        {
            List<Ad> ads = new List<Ad>();
            string sql = "SELECT * FROM ads";
            using (MySqlConnection conn = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {

                        cmd.Connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ads.Add(new Ad()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Title = reader.GetString("Title"),
                                        Price = reader.GetDecimal("Price"),
                                        Description = reader.GetString("Description"),
                                        Condition = reader.GetString("Condition")
                                    });
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
            return ads;
        }

        public static List<Ad> GetUserAds(int UserId)
        {
            List<Ad> ads = new List<Ad>();
            string sql = "SELECT * FROM ads a WHERE a.UserId = @UserId";

            using (MySqlConnection conn = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {

                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@UserId", UserId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ads.Add(new Ad()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Title = reader.GetString("Title"),
                                        Price = reader.GetDecimal("Price"),
                                        Description = reader.GetString("Description"),
                                        Condition = reader.GetString("Condition")
                                    });
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
            return ads;
        }

        public static Ad CreateAd(Ad ad)
        {
            string sql = @"INSERT INTO ads (Title, `Condition` , Description, Price, UserId) VALUES(@Title, @Condition, @Description, @Price, @UserId); SELECT LAST_INSERT_ID();";

            using (MySqlConnection conn = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@Title", ad.Title);
                        cmd.Parameters.AddWithValue("@Condition", ad.Condition);
                        cmd.Parameters.AddWithValue("@Description", ad.Description);
                        cmd.Parameters.AddWithValue("@Price", ad.Price);
                        cmd.Parameters.AddWithValue("@UserId", ad.User.Id);
                        string o = cmd.ExecuteScalar().ToString();
                        long id = 0;
                        long.TryParse(o, out id);
                        ad.Id = id;
                    }
                    catch (Exception ex)
                    {
                        _error.Log(ex);
                    }
                }
            }
            return ad;
        }

        public static Ad UpdateAd(Ad ad)
        {
            string sql = @"UPDATE ads SET Title = @Title, Condition = @Condition , Description = @Description, Price = @Price WHERE Id = @Id";
            using (MySqlConnection conn = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@Title", ad.Title);
                        cmd.Parameters.AddWithValue("@Condition", ad.Condition);
                        cmd.Parameters.AddWithValue("@Description", ad.Description);
                        cmd.Parameters.AddWithValue("@Price", ad.Price);
                        string o = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        _error.Log(ex);
                    }
                }
            }
            return ad;
        }

        public static Ad GetUserAd(int Id)
        {
            Ad ad = null;
            string sql = "SELECT * FROM ads WHERE Id=@Id";
            using (MySqlConnection conn = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@Id", Id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    ad = new Ad()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Title = reader.GetString("Title"),
                                        Price = reader.GetDecimal("Price"),
                                        Description = reader.GetString("Description"),
                                        Condition = reader.GetString("Condition")
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
            return ad;
        }
    }
}