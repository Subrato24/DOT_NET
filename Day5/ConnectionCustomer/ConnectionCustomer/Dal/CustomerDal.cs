using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionCustomer.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ConnectionCustomer.Dal
{
    internal class CustomerDal
    {
        public List<Customer> GetAllCustomers()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "getCustomerAll";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Customer> customers = new List<Customer>();
                    while (DR.Read())
                    {
                        customers.Add(new Customer()
                        {
                            ID = Convert.ToInt32(DR["ID"]),
                            NAME = Convert.ToString(DR["NAME"]),
                            ADDRESS = Convert.ToString(DR["ADDRESS"]),
                            PH_NUMBER = Convert.ToString(DR["PH_NUMBER"]),
                            Email = Convert.ToString(DR["Email"]),
                            GENDER = Convert.ToString(DR["GENDER"]),
                        });
                    }
                    DR.Close();
                    CN.Close();
                    return customers;
                }
            }
        }
        public int InsertCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "insertCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerName", customer.NAME);
                    CMD.Parameters.AddWithValue("p_CustomerAddress", customer.ADDRESS);
                    CMD.Parameters.AddWithValue("p_CustomerNumber", customer.PH_NUMBER);
                    CMD.Parameters.AddWithValue("p_CustomerEmail", customer.Email);
                    CMD.Parameters.AddWithValue("p_CustomerGender", customer.GENDER);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int UpdateCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "updateCustomer";
                    CMD.Parameters.AddWithValue("p_customerId", customer.ID);
                    CMD.Parameters.AddWithValue("p_customerName", customer.NAME);
                    CMD.Parameters.AddWithValue("p_customerAddress", customer.ADDRESS);
                    CMD.Parameters.AddWithValue("p_customerNumber", customer.PH_NUMBER);
                    CMD.Parameters.AddWithValue("p_customerEmail", customer.Email);
                    CMD.Parameters.AddWithValue("p_customerGender", customer.GENDER);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int DeleteCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "deleteCustomer";
                    CMD.Parameters.AddWithValue("p_Id", customer.ID);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }



    }
}
