using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthClub healthClub = new HealthClub();

            healthClub.AddEmployee("E001");
            healthClub.AddEmployee("E002");
            healthClub.Display();

            healthClub.DeleteEmployee("E001");
            healthClub.Display();

            healthClub.DeleteEmployee("E003");
            healthClub.Display();
        }
    }
}
