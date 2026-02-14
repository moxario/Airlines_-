using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines_Яшин.Models;

namespace Airlines_Яшин.Classes
{
    public class TicketContext : Ticket
    {


        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickest = new List<TicketContext>();
            return allTickest;
        }
    }
}
