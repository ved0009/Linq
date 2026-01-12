using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class JoinsGroupBy
    {
        // ================== MODELS ==================

        public class Department
        {
            public int DepartmentId { get; set; }
            public string DepartmentName { get; set; }
        }

        public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public int? DepartmentId { get; set; }
        }

        public class Salary
        {
            public int SalaryId { get; set; }
            public int EmployeeId { get; set; }
            public decimal Amount { get; set; }
            public string SalaryMonth { get; set; }
        }

        // ================== STATIC DATA ==================

        public static List<Department> Departments = new()
        {
            new Department { DepartmentId = 1, DepartmentName = "IT" },
            new Department { DepartmentId = 2, DepartmentName = "HR" },
            new Department { DepartmentId = 3, DepartmentName = "Finance" },
            new Department { DepartmentId = 4, DepartmentName = "Sales" }
        };

        public static List<Employee> Employees = new()
        {
            new Employee { EmployeeId = 1, Name = "Amit", DepartmentId = 1 },
            new Employee { EmployeeId = 2, Name = "Neha", DepartmentId = 1 },
            new Employee { EmployeeId = 3, Name = "Ravi", DepartmentId = 1 },

            new Employee { EmployeeId = 4, Name = "Rahul", DepartmentId = 2 },
            new Employee { EmployeeId = 5, Name = "Pooja", DepartmentId = 2 },

            new Employee { EmployeeId = 6, Name = "Ankit", DepartmentId = 3 },

            new Employee { EmployeeId = 7, Name = "Priya", DepartmentId = null },
            new Employee { EmployeeId = 8, Name = "Suresh", DepartmentId = 4 },
            new Employee { EmployeeId = 9, Name = "Kiran", DepartmentId = 4 }
        };

        public static List<Salary> Salaries = new()
        {
            new Salary { SalaryId = 1, EmployeeId = 1, Amount = 50000, SalaryMonth = "Jan" },
            new Salary { SalaryId = 2, EmployeeId = 1, Amount = 50000, SalaryMonth = "Feb" },
            new Salary { SalaryId = 3, EmployeeId = 1, Amount = 55000, SalaryMonth = "Mar" },

            new Salary { SalaryId = 4, EmployeeId = 2, Amount = 45000, SalaryMonth = "Jan" },
            new Salary { SalaryId = 5, EmployeeId = 2, Amount = 45000, SalaryMonth = "Feb" },

            new Salary { SalaryId = 6, EmployeeId = 3, Amount = 40000, SalaryMonth = "Jan" },

            new Salary { SalaryId = 7, EmployeeId = 4, Amount = 35000, SalaryMonth = "Jan" },
            new Salary { SalaryId = 8, EmployeeId = 4, Amount = 35000, SalaryMonth = "Feb" },

            new Salary { SalaryId = 9, EmployeeId = 5, Amount = 30000, SalaryMonth = "Jan" },

            new Salary { SalaryId = 10, EmployeeId = 6, Amount = 60000, SalaryMonth = "Jan" },
            new Salary { SalaryId = 11, EmployeeId = 6, Amount = 60000, SalaryMonth = "Feb" },

            new Salary { SalaryId = 12, EmployeeId = 8, Amount = 25000, SalaryMonth = "Jan" }
        };
    }
}
