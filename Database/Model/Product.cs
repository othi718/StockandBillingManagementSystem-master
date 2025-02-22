using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Product

    {

        [key]
        public  int ProductId {get; set;}
        //public DateTime Date { get; set; }
        public  string ProductName { get; set; }
        public string ProductDescripton { get; set; }


    }
}
