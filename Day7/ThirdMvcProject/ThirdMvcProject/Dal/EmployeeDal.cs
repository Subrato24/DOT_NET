using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Dal
{
    public class EmployeeDal
    {
        public List<Employee> getAllEmployee()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = System.Data.CommandType.StoredProcedure;
                    CMD.CommandText = "getAllEmployee";
                    MySqlDataReader RD = CMD.ExecuteReader();
                    List<Employee> list = new List<Employee>();
                    while (RD.Read())
                    {
                        list.Add(new Employee
                        {
                            empId = Convert.ToInt32(RD["empId"]),
                            empName = Convert.ToString(RD["empName"]),
                            city = Convert.ToString(RD["city"]),
                            country = Convert.ToString(RD["country"]),
                            phone = Convert.ToString(RD["phone"]),
                            email = Convert.ToString(RD["email"]),
                            skillset = Convert.ToString(RD["skillset"]),
                            avatar = Convert.ToString(RD["avatar"]),
                            zipcode = Convert.ToString(RD["zipcode"])
                        });
                    }
                    RD.Close();
                    CN.Close();
                    return list;
                }
            }
        }
        public Employee getEmployeeById(int EmpId)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "getEmployeeById";
                    CMD.Parameters.AddWithValue("e_Id", EmpId);
                    MySqlDataReader RD = CMD.ExecuteReader();
                    RD.Read();

                    Employee e = new Employee()
                    {
                        empId = Convert.ToInt32(RD["empId"]),
                        empName = Convert.ToString(RD["empName"]),
                        city = Convert.ToString(RD["city"]),
                        country = Convert.ToString(RD["country"]),
                        phone = Convert.ToString(RD["phone"]),
                        email = Convert.ToString(RD["email"]),
                        skillset = Convert.ToString(RD["skillset"]),
                        avatar = "/Images/shreeRam",
                        //logo = Convert.ToString(RD["logo"]),
                        zipcode = Convert.ToString(RD["zipcode"])
                    };
                    RD.Close();
                    CN.Close();
                    return e;
                }

            }
        }
        public int InsertEmployee(Employee emp)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "addemployee";
                    CMD.Parameters.AddWithValue("e_name", emp.empName);
                    CMD.Parameters.AddWithValue("e_city", emp.city);
                    CMD.Parameters.AddWithValue("e_country", emp.country);
                    CMD.Parameters.AddWithValue("e_phone", emp.phone);
                    CMD.Parameters.AddWithValue("e_email", emp.email);
                    CMD.Parameters.AddWithValue("e_skillset", emp.skillset);
                    CMD.Parameters.AddWithValue("e_avatar", emp.avatar);
                    CMD.Parameters.AddWithValue("e_zipcode", emp.zipcode);
                    int result = CMD.ExecuteNonQuery();
                    CN.Close();
                    return result;
                }
            }
        }
        
    }
}