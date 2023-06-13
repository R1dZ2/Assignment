using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infosys.EmployeeManagement
{
    public class Employee
    {
        private static int counter;
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int JobLevel { get; set; }
        public DateTime JoiningDate { get; set; }
        public string ProjectCode { get; set; }
        public double Salary { get; set; }
        public int UnitId { get; set; }

        static Employee()
        {
            counter = 1000;
        }

        public Employee()
        {
            EmployeeId = "E" + counter++;
        }
    }
}
