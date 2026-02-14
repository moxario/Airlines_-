using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Яшин.Models
{
    public class Ticket
    {
        public int Price { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Ticket(int Price, string From, string To, DateTime StartTime, DateTime EndTime) {
            this.Price = Price;
            this.From = From;
            this.To = To;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }

    }
}
