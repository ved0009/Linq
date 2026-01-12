using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
    internal static class QuerryOperators
    {
        internal static List<Employee> GetData()
        {
            return new List<Employee>
            {
               new Employee { ID = 1, FirstName = "John",LastName = "Smith", Age = 30, Department = "HR", Salary = 25000 },
                new Employee { ID = 2, FirstName = "Ava", LastName = "Jones", Age = 31, Department = "HR", Salary = 27000 },
                new Employee { ID = 3, FirstName = "William", LastName = "Brown", Age = 22, Department = "DEV",Salary = 25500 },
                new Employee { ID = 4, FirstName = "Emma",LastName = "Taylor",Age = 28, Department = "QA", Salary = 26000 },
                new Employee { ID = 5, FirstName = "Liam",LastName = "Wilson",Age = 35, Department = "Management", Salary = 42000 },
                new Employee { ID = 6, FirstName = "Olivia",LastName = "Moore", Age = 26, Department = "ClientSupport",Salary = 23000 },
                new Employee { ID = 7, FirstName = "Noah",LastName = "Anderson",Age = 29, Department = "DEV",Salary = 30000 },
                new Employee { ID = 8, FirstName = "Sophia",LastName = "Thomas",Age = 33, Department = "QA", Salary = 28000 },
                new Employee { ID = 9, FirstName = "John", LastName = "Martin",Age = 41, Department = "Management", Salary = 48000 },
                new Employee { ID = 10,FirstName = "Isabella",LastName = "Lee", Age = 24, Department = "ClientSupport",Salary = 22000 },
                new Employee { ID = 11,FirstName = "Benjamin",LastName = "Clark", Age = 27, Department = "DEV",Salary = 32000 },
                new Employee { ID = 12,FirstName = "Mia", LastName = "Harris",Age = 34, Department = "HR", Salary = 29000 }


            };
        }

    }
}
