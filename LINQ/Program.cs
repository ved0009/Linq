using LINQ;
using System.Xml.Linq;

List<Employee> employees = QuerryOperators.GetData();

//employees.ForEach(e =>  Console.WriteLine("ID: {0}, FirstName: {1}, LastName: {2}, Age: {3}, Department: {4}, Salary : {5}", 
//                        e.ID, e.FirstName, e.LastName, e.Age, e.Department, e.Salary)
//                    );

//foreach (Employee e in employees)
//{Console.WriteLine("ID: {0}, FirstName: {1}, LastName: {2}, Age: {3}, Department: {4}, Salary : {5}",
//e.ID, e.FirstName, e.LastName, e.Age, e.Department, e.Salary);
//}


// SELECT, DISTINCT  , UPDATE, FROM , WHERE , GROP BY, JOIN, Order BY (ASC, DESC), TOP 1, TOP n

//Select , Distinct 
var SelectDistinct =  employees.Select(e => e.FirstName)
                                        .Distinct()
                                        .ToList();
foreach (var name in SelectDistinct)
{
    Console.WriteLine(name);

}


Employee employeesF = employees.First(e=> e.FirstName=="Mia");
Console.WriteLine("ID: {0}, FirstName: {1}, LastName: {2}, Age: {3}, Department: {4}, Salary : {5}",
                     employeesF.ID, employeesF.FirstName, employeesF.LastName, employeesF.Age, employeesF.Department, employeesF.Salary);




//Order By, Then By 
employees = employees.OrderBy(e => e.FirstName)
                     .ThenBy(e => e.LastName)
                     .ThenBy(e=>e.Age)
                     .ToList();



Console.WriteLine("\n");
foreach (var name in employees)
{
    Console.WriteLine(name.FirstName+" "+name.LastName + " " + name.Age);

}
