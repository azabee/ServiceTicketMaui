using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceTicketMaui.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "";
    }
}
