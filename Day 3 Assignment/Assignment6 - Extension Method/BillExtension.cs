using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6___Extension_Method
{
    public static class BillExtension
    {
        static BillExtension()
        {
            
        }

        public static double CalculateServiceTax(this Bill obj, double totalAmount)
        {
            double serviceTax = 0;
            if (totalAmount < 2000) 
            {
                serviceTax = 0;
            }
            else if(totalAmount >=2000 && totalAmount<=5000)
            {
                serviceTax = 0.02;
            }
            else if (totalAmount > 5000)
            {
                serviceTax = 0.05;
            }

            return serviceTax * totalAmount;
        }
    }
}
