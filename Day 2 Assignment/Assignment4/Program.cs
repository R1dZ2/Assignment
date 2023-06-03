using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GiveBonus(1, 3000);
            Console.WriteLine(employee.Account.Balance);
            employee.GiveBonus(1, 3000);
            Console.WriteLine(employee.Account.Balance);
        }
    }
}
