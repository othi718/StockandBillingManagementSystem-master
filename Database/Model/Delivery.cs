using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Deliver
    {
        public int DeliverId { get; set; }
        public DateTime DeliverDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ProductId { get; set; }

    
    }
}
