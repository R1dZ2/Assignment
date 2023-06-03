using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6___Extension_Method
{
    public class Bill
    {
        public string BillId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Bill()
        {
            
        }

        public Bill(string billId, int quantity, double price):base()
        {
            BillId = billId;
            Quantity = quantity;
            Price = price;
        }
    }
}
