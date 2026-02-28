using Airlines_Яшин.Classes;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Airlines_Яшин.Pages
{
    /// <summary>
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        public List<TicketContext> AllTickets;
        public Ticket(string From, string To)
        {
            InitializeComponent();
            AllTickets = TicketContext.AllTickets().FindAll(x =>
            (x.From == From && To == "") ||
            (From == "" && x.To == To) ||
            (x.From == From && x.To == To));
            CreateUI();
        }
        public void CreateUI()
        {
            foreach(TicketContext ticket in AllTickets)
            {
                parent.Children.Add(new Elements.Item(ticket));
            }
        }
    }
}
