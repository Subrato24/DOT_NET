using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Dal
{
    public class SecurityDal
    {
        public List<User> getAllUser()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = System.Data.CommandType.StoredProcedure;
                    CMD.CommandText = "getAllUser";
                    MySqlDataReader RD = CMD.ExecuteReader();
                    List<User> list = new List<User>();
                    while (RD.Read())
                    {
                        list.Add(new User
                        {
                            userId = Convert.ToInt32(RD["userId"]),
                            email = Convert.ToString(RD["email"]),
                            password = Convert.ToString(RD["password"]),
                            rolename = Convert.ToString(RD["rolename"])
                        });
                    }
                    RD.Close();
                    CN.Close();
                    return list;
                }
            }
        }
        public User getuserById(int UId)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "getUserById";
                    CMD.Parameters.AddWithValue("u_Id", UId);
                    MySqlDataReader RD = CMD.ExecuteReader();
                    RD.Read();

                    User u = new User()
                    {
                        userId = Convert.ToInt32(RD["userId"]),
                        email = Convert.ToString(RD["email"]),
                        password = Convert.ToString(RD["password"]),
                        rolename = Convert.ToString(RD["rolename"])
                    };
                    RD.Close();
                    CN.Close();
                    return u;
                }

            }
        }
        public int addUser(User u)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "addUser";
                    CMD.Parameters.AddWithValue("u_email", u.email);
                    CMD.Parameters.AddWithValue("u_password", u.password);
                    CMD.Parameters.AddWithValue("u_rolename", u.rolename);
                    int result = CMD.ExecuteNonQuery();
                    CN.Close();
                    return result;
                }
            }
        }
        public User Authenticate(User user)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "validUser";
                    CMD.Parameters.AddWithValue("u_email", user.email);
                    CMD.Parameters.AddWithValue("u_password", user.password);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DR.Read();
                    User existingUser = new User()
                    {
                        email = Convert.ToString(DR["email"]),
                        password = Convert.ToString(DR["password"]),
                    };

                    DR.Close();
                    CN.Close();
                    return existingUser;
                }
            }
        }
    }
}