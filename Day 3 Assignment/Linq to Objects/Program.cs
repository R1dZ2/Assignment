namespace Infosys.EmployeeManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Unit> unitList = new List<Unit>()
            {
         new Unit{ UnitId = 10, UnitName = "ETA"},
         new Unit{ UnitId = 20, UnitName = "FSI"},
         new Unit{ UnitId = 30, UnitName = "ECS"}
            };
            List<Employee> employeeList = new List<Employee>()
            {
         new Employee {EmployeeName = "John",UnitId=10,ProjectCode="ETAMYS",Salary=30000,JobLevel=3,JoiningDate=new DateTime(2014,3,5)},
         new Employee {EmployeeName = "Jack",UnitId=10,ProjectCode="ETACHN",Salary=35000,JobLevel=3,JoiningDate=new DateTime(2011,3,5)},
         new Employee {EmployeeName = "Albus",UnitId=10,ProjectCode="ETACHN",Salary=15000,JobLevel=4,JoiningDate=new DateTime(2011,3,5)},
         new Employee {EmployeeName = "Ron",UnitId=20,ProjectCode="FSIAUS",Salary=10000,JobLevel=4,JoiningDate=new DateTime(2007,2,5)},
         new Employee {EmployeeName = "Iwa",UnitId=20,ProjectCode="FSIAUS",Salary=15000,JobLevel=4,JoiningDate=new DateTime(2007,2,5)},
         new Employee {EmployeeName = "Albert",UnitId=30,ProjectCode=null,Salary=20000,JobLevel=3,JoiningDate=new DateTime(2005,1,5)}
            };

            #region 1. Query One

            //Display the EmployeeName, UnitId and ProjectCode of those Employees, whose Salary is between 15000 and 20000.

            var employeeSalaryFilter = (from employee in employeeList
                                        where employee.Salary >= 15000 && employee.Salary <= 20000
                                        select new { employee.EmployeeName, employee.UnitId, employee.ProjectCode })
                                        .ToList();
            Console.WriteLine("Employee whose Salary is between 15000 and 20000");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1, -18}{2}", "EmployeeName", "UnitId", "ProjectCode");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in employeeSalaryFilter)
            {
                Console.WriteLine("{0, -18}{1, -18}{2}", item.EmployeeName, item.UnitId, item.ProjectCode);
            }
            #endregion

            #region 2. Query Two
            //Display the EmployeeName, TotalExperience in years of those employees, who have more than three years of experience.

            var employeeYearFilter = (from employee in employeeList
                                      where (DateTime.Now - employee.JoiningDate).Days / 365 > 3
                                      select new { employee.EmployeeName, Experience = (DateTime.Now - employee.JoiningDate).Days / 365 })
                            .ToList();
            Console.WriteLine("\n");
            Console.WriteLine("Employee who have more than 3 years of experience");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "EmployeeName", "Experience");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in employeeYearFilter)
            {
                Console.WriteLine("{0, -18}{1}", item.EmployeeName, item.Experience);
            }
            #endregion

            #region 3. Query Three
            //Display the EmployeeName of those employees, who are not assigned to any project.

            var employeeNotAssigned = (from employee in employeeList
                                       where employee.ProjectCode == null
                                       select new { employee.EmployeeName })
                            .ToList();
            Console.WriteLine("\n");
            Console.WriteLine("Employees who are not assigned to any project");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0}", "EmployeeName");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in employeeNotAssigned)
            {
                Console.WriteLine("{0}", item.EmployeeName);
            }
            #endregion

            #region 4. Query Four
            //Display the total amount of Salary drawn by all the employees.

            var totalSalary = (from employee in employeeList
                               select new { Total = employeeList.Sum(s => s.Salary) }).FirstOrDefault();
            Console.WriteLine("\n");
            Console.WriteLine("Salary drawn by all the employees");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0}", "TotalSalary");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("{0}", totalSalary.Total);

            #endregion

            #region 5. Query Five
            //Display the total amount of salaries drawn by all those employees, who are in JobLevel 3.

            var totalSalaryInJobLevel3 = (from employee in employeeList
                                          select new { Total = employeeList.Where(e => e.JobLevel == 3).Sum(x => x.Salary) }).FirstOrDefault();
            Console.WriteLine("\n");
            Console.WriteLine("Salary drawn by all the employees in JobLevel 3");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0}", "TotalSalary");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0}", totalSalaryInJobLevel3.Total);
            #endregion

            #region 6. Query Six
            //Display the EmployeeName and UnitName of all the employees in the ascending order of employee names.

            var employeeUnitList = (from employee in employeeList
                                    join unit in unitList
                                    on employee.UnitId equals unit.UnitId
                                    orderby employee.EmployeeName ascending
                                    select new { employee.EmployeeName, unit.UnitName });

            Console.WriteLine("\n");
            Console.WriteLine("EmployeeName and UnitName of all the employees");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "EmployeeName", "UnitName");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in employeeUnitList)
            {
                Console.WriteLine("{0, -18}{1}", item.EmployeeName, item.UnitName);
            }
            #endregion

            #region 7. Query Seven
            //Display the EmployeeName and Salary of employee(s), who are drawing minimum salary.

            var employeeMinSalary = (from employee in employeeList
                                     where employee.Salary == employeeList.Min(x => x.Salary)
                                     select new { employee.EmployeeName, Minimum = employee.Salary }).ToList();

            Console.WriteLine("\n");
            Console.WriteLine("Minimum Salary");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "EmployeeName", "Salary");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in employeeMinSalary)
            {
                Console.WriteLine("{0, -18}{1}", item.EmployeeName, item.Minimum);
            }
            #endregion

            #region 8. Query Eight
            //Display the EmployeeName and JoiningDate of employee(s), who are the most experienced.

            var mostExperienced = (from employee in employeeList
                                   where employee.JoiningDate == employeeList.Min(x => x.JoiningDate)
                                   select new { employee.EmployeeName, employee.JoiningDate }).ToList();

            Console.WriteLine("\n");
            Console.WriteLine("Most Experienced");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "EmployeeName", "Joining date");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in mostExperienced)
            {
                Console.WriteLine("{0, -18}{1}", item.EmployeeName, item.JoiningDate);
            }
            #endregion

            #region 9. Query Nine
            //Display the UnitId and number of employees in each unit

            var employeePerUnit = from employee in employeeList
                                  group employee by employee.UnitId
                                   into g
                                  select new { g.Key, NumberOfEmployees = g.Count() };

            Console.WriteLine("\n");
            Console.WriteLine("Number of Employees in each unit");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "UnitId", "Number of Employees");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in employeePerUnit)
            {
                Console.WriteLine("{0, -18}{1}", item.Key, item.NumberOfEmployees);
            }
            #endregion


            #region 10. Query Ten
            //Display the UnitId and Number of employees in each unit, whose Salary is greater than 10000

            var employeePerUnitGreaterThan3 = from employee in employeeList
                                              where employee.Salary > 10000
                                              group employee by employee.UnitId
                                              into g
                                              select new { g.Key, NumberOfEmployees = g.Count() };

            Console.WriteLine("\n");
            Console.WriteLine("Number of employees in each unit, whose Salary is greater than 10000");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "UnitId", "Number of Employees");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in employeePerUnitGreaterThan3)
            {
                Console.WriteLine("{0, -18}{1}", item.Key, item.NumberOfEmployees);
            }
            #endregion

            #region 11. Query Eleven
            //Display the UnitId and total amount of salaries drawn by employees in each unit

            var totalSalaryInEachUnit = from employee in employeeList
                                              group employee.Salary by employee.UnitId
                                              into g
                                              select new { g.Key, TotalSalary = g.Sum() };

            Console.WriteLine("\n");
            Console.WriteLine("total amount of salaries drawn by employees in each unit");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "UnitId", "Number of Employees");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in totalSalaryInEachUnit)
            {
                Console.WriteLine("{0, -18}{1}", item.Key, item.TotalSalary);
            }
            #endregion

            #region 12. Query Twelve
            //Display the UnitId and total salary drawn by employees for all those units where the unit's total salary is greater than 20000

            var salaryGreaterThan20000 = from employee in employeeList
                                        group employee.Salary by employee.UnitId
                                              into g
                                         where g.Sum() > 20000
                                        select new { g.Key, TotalSalary = g.Sum() };

            Console.WriteLine("\n");
            Console.WriteLine("total salary drawn by employees where the unit's total salary is greater than 20000");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "UnitId", "Number of Employees");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in salaryGreaterThan20000)
            {
                Console.WriteLine("{0, -18}{1}", item.Key, item.TotalSalary);
            }
            #endregion

            #region 13. Query Thirteen
            //Display the UnitId and total salary drawn by employees of job level 3 in each unit for all those units where total salary of all JobLevel 3 employees is greater than 20000

            var salaryJob3GreaterThan20000 = from employee in employeeList
                                             where employee.JobLevel == 3
                                         group employee.Salary by employee.UnitId into g
                                         where g.Sum() > 20000
                                         select new { g.Key, TotalSalary = g.Sum() };

            Console.WriteLine("\n");
            Console.WriteLine("total salary drawn by employees level 3 where the unit's total salary is greater than 20000");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "UnitId", "Number of Employees");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in salaryJob3GreaterThan20000)
            {
                Console.WriteLine("{0, -18}{1}", item.Key, item.TotalSalary);
            }
            #endregion

            #region 14. Query Fourteen
            //Display the UnitName and maximum salary drawn by employees in each unit in the descending order of maximum salary

            var maxSalarySorted = from employee in employeeList
                                  join unit in unitList
                                  on employee.UnitId equals unit.UnitId
                                  group employee.Salary by unit.UnitName into g
                                  orderby g.Max() descending
                                  select new {g.Key, MaxSalary = g.Max()};

            Console.WriteLine("\n");
            Console.WriteLine("maximum salary drawn by employees in each unit in the descending order of maximum salary");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1}", "UnitId", "Number of Employees");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in maxSalarySorted)
            {
                Console.WriteLine("{0, -18}{1}", item.Key, item.MaxSalary);
            }
            #endregion

/*            #region 15. Query Fifteen
            //Display the EmployeeName, UnitId, Salary and ProjectCode of those employees, who draw minimum salary in each unit

            var minSalarySorted = from employee in employeeList
                                  group employee.Salary by employee.UnitId into g
                                  let minSalary = g.Min(emp=>emp.Salary)
                                  from emp in g
                                  where emp.Salary == minSalary
                                  select new { emp.EmployeeName, emp.UnitId, emp.Salary, emp.ProjectCode };

            Console.WriteLine("\n");
            Console.WriteLine("EmployeeName, UnitId, Salary and ProjectCode of those employees, who draw minimum salary in each unit");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0, -18}{1, -18}{2, -18}{3}", "UnitId", "Number of Employees");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var item in minSalarySorted)
            {
                Console.WriteLine("{0, -18}{1, -18}{2, -18}{3}",item.EmployeeName, item.UnitId,item.MinSalary, item.ProjectCode);
            }
            #endregion*/

        }
    }
}