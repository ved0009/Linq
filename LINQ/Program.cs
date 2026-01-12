using LINQ;
using System.Xml.Linq;

using System;
using System.Linq;
using static LINQ.JoinsGroupBy;

 
        
            Console.WriteLine("===== SALARIES TABLE DATA =====\n");

            foreach (var salary in Salaries)
            {
                Console.WriteLine(
                    $"SalaryId: {salary.SalaryId}, " +
                    $"EmployeeId: {salary.EmployeeId}, " +
                    $"Amount: {salary.Amount}, " +
                    $"Month: {salary.SalaryMonth}");
            }

            Console.WriteLine("\n================================\n");

//Q1. Department-wise Employee Count
Console.WriteLine("\nQ1. Department-wise Employee Count");
var DepartmentName = from Dep in Departments
                     join e in Employees
                     on Dep.DepartmentId equals e.DepartmentId into empGroup
                     select new
                     {
                         Dep.DepartmentName,
                         EmployeeCount = empGroup.Count(),
                     };

foreach (var item in DepartmentName)
{
    Console.WriteLine($"{item.DepartmentName} : {item.EmployeeCount}");
}

// Q2. Employees With No Department
Console.WriteLine("\nQ2. Employees With No Department");
var EmpwithNoDept = from e in Employees
                    where e.DepartmentId == null
                    select e.Name;

foreach (var name in EmpwithNoDept)
{
    Console.WriteLine(name);
}

//Q3.Employee - wise Total Salary
Console.WriteLine("\nQ3.Employee - wise Total Salary");
var empTotalsalary =
    from e in Employees
    join s in Salaries
    on e.EmployeeId equals s.EmployeeId into empGroup
    select new
    {
        e.Name,
        SalayCount = empGroup.Sum(x=>x.Amount)
    };

foreach (var item in empTotalsalary)
{
    Console.WriteLine($"{item.Name} : {item.SalayCount}");
}

//Q4 Employees With No Salary
Console.WriteLine("\nEmployees With No Salary");

var empwithNoSal =
        from e in Employees
        join s in Salaries
        on e.EmployeeId equals s.SalaryId into salaryGroup
        from sg in salaryGroup.DefaultIfEmpty()
        where sg == null
        select e.Name;

foreach (var name in empwithNoSal)
{
    Console.WriteLine(name);
}