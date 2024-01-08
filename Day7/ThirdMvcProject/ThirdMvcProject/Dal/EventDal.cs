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
    public class EventDal
    {
        public List<Event> GetAllEvent()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "getAllEvents";
                    MySqlDataReader RD = CMD.ExecuteReader();
                    List<Event> list = new List<Event>();
                    while (RD.Read())
                    {
                        list.Add(new Event
                        {
                            eventId = Convert.ToInt32(RD["eventId"]),
                            eventName = Convert.ToString(RD["eventName"]),
                            description = Convert.ToString(RD["Description"]),
                            startdate = Convert.ToString(RD["startdate"]),
                            enddate = Convert.ToString(RD["enddate"]),
                            fees = Convert.ToString(RD["fees"]),
                            totalseatfilled = Convert.ToString(RD["totalseatfilled"]), 
                            logo = Convert.ToString(RD["logo"]),
                            code = Convert.ToString(RD["code"])
                        });
                    }
                    RD.Close();
                    CN.Close();
                    return list;
                }
            }
        }
        public Event GetEventById(int EventId)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "getEventById";
                    CMD.Parameters.AddWithValue("ev_eventId", EventId);
                    MySqlDataReader RD = CMD.ExecuteReader();
                    RD.Read();

                    Event e = new Event()
                    {
                        eventId = Convert.ToInt32(RD["eventId"]),
                        eventName = Convert.ToString(RD["eventName"]),
                        description = Convert.ToString(RD["Description"]),
                        startdate = Convert.ToString(RD["startdate"]),
                        enddate = Convert.ToString(RD["enddate"]),
                        fees = Convert.ToString(RD["fees"]),
                        totalseatfilled = Convert.ToString(RD["totalseatfilled"]),
                        logo = "/Images/shreeRam",
                        //logo = Convert.ToString(RD["logo"]),
                        code = Convert.ToString(RD["code"])
                    };
                    RD.Close();
                    CN.Close();
                    return e;
                }
    
            }
        }
        public int InsertEvent(Event eve)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "addEvent";
                    CMD.Parameters.AddWithValue("ev_name", eve.eventName);
                    CMD.Parameters.AddWithValue("ev_description",eve.description);
                    CMD.Parameters.AddWithValue("ev_startdate", eve.startdate);
                    CMD.Parameters.AddWithValue("ev_enddate", eve.enddate);
                    CMD.Parameters.AddWithValue("ev_fees", eve.fees);
                    CMD.Parameters.AddWithValue("ev_totalseatfilled", eve.totalseatfilled);
                    CMD.Parameters.AddWithValue("ev_logo",eve.logo);
                    CMD.Parameters.AddWithValue("ev_code", eve.code);
                    int result = CMD.ExecuteNonQuery();
                    CN.Close();
                    return result;
                }
            }
        }
    }
}   