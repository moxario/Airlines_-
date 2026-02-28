using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines_Яшин.Models;
using MySql.Data.MySqlClient;

namespace Airlines_Яшин.Classes
{
    public class TicketContext : Ticket
    {

        public TicketContext(int Price, string From, string To, DateTime StartTime, DateTime EndTime) : base(Price, From, To, StartTime, EndTime) { }
        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickest = new List<TicketContext>();
            MySqlConnection connection = WorkingDB.Connection.OpenConnection();
            MySqlDataReader ticketQuery = WorkingDB.Connection.Query("SELECT * FROM `Airlines`.'Tickets';", connection);
            while (ticketQuery.Read())
            {
                allTickest.Add(new TicketContext(
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetString(1),
                    ticketQuery.GetString(2),
                    ticketQuery.GetDateTime(4),
                    ticketQuery.GetDateTime(5)

                    ));

            }
            WorkingDB.Connection.CloseConnection(connection);
            return allTickest;
        }
    }
}
