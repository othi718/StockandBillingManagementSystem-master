using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Billing : Stock
    {
        public int BillingId { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}
