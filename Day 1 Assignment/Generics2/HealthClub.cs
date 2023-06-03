using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class HealthClub
    {
        private List<string> employeeIdList;

        public List<string> EmployeeIdList
        {
            get { return employeeIdList; }
            set { employeeIdList = value; }
        }

        public HealthClub()
        {
            EmployeeIdList = new List<string>();
        }

        public void AddEmployee(string employeeId)
        {
            EmployeeIdList.Add(employeeId);
        }

        public bool DeleteEmployee(string employeedId)
        {
            bool isPresent = false;
            if (EmployeeIdList.Contains(employeedId))
            {
                isPresent = true;
                EmployeeIdList.Remove(employeedId);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Employee not present");
            }

            return isPresent;
        }

        public void Display()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("EmployeeId");

            foreach(string employee in EmployeeIdList)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
