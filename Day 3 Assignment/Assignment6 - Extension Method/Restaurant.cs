using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6___Extension_Method
{
    public class Restaurant
    {
        public Restaurant() { }

        public double CalculateAmount(Bill billObj)
        {
            double totalBillAmount = billObj.Quantity * billObj.Price;
            var serviceTax = BillExtension.CalculateServiceTax(billObj, totalBillAmount);
            return serviceTax+totalBillAmount;
        }
    }
}
