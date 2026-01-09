

/* Where */
// Even numbers + > 0
 
var numbers = new List<int>() { 1, 3, 4, 5, 2, 2, 2, 0, 6, 7 };
var result = numbers.Where(x => x % 2 == 0 && x!=0).ToList();

Console.WriteLine("\nWhere.........");
foreach (var i in result)
{
    Console.WriteLine(i);
}

/* Select */
//  Har number ka square nikaalo

var T3Select = new List<int>() { 2, 3, 4, 5 };
var result3 = T3Select.Select(x => x * x).ToList();

Console.WriteLine("\nSelect.........");
foreach (var i in result3)
{
    Console.WriteLine(i);
}

#region Element Operators – First, FirstOrDefault, Single

Console.WriteLine("\n\nElement Operators – First, FirstOrDefault, Single");
/* Specific element safely fetch karo. */
// TODO:
// 1. First element
// 2. First element jo "Guest" ho (safe)
// 3. Single element "Admin"


var users = new List<string>() { "Admin", "User", "Manager" };

 var first= users.First();
var FirstOrDefault = users.FirstOrDefault();
var Single = users.Single(x=> x=="User");

Console.WriteLine("\nfirst........."); 
Console.WriteLine(first);


Console.WriteLine("\nFirstOrDefault.........");
Console.WriteLine(FirstOrDefault);


Console.WriteLine("\nSingle.........");
Console.WriteLine(Single);


#endregion

#region Partition Operators – Skip, Take

Console.WriteLine("\n\nPartition Operators – Skip, Take");
/* Partition Operators – Skip, Take */
//Pagination logic implement karo.
// TODO:
// PageSize = 3
// PageNumber = 2
// Skip + Take use karke data lao


var records = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int PageSize = 2;
int PageNumber = 2;

Console.WriteLine("\n– Skip, Take.........");
var Skip = records
            .Skip((PageNumber - 1) * PageSize)
            .Take(PageSize);
foreach (var record in Skip)
{
    Console.WriteLine(record);
}

#endregion

#region Grouping Operator – GroupBy


Console.WriteLine("\n\nGrouping Operator – GroupBy");
/*Even / Odd grouping. */
// TODO:
// Even aur Odd group banao
// Group key + values print karo

var T10numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

Console.WriteLine("\nGroupBy.........");
var GroupData = T10numbers
                .GroupBy(x => x % 2 == 0 ? "Even" : "Odd");

foreach (var i in GroupData)
{
    Console.WriteLine(i.Key);
    foreach(var value in i)
    {
        Console.WriteLine(value);
    }
}

#endregion


#region Generation Operators – Range, Repeat


Console.WriteLine("\n\nGeneration Operators – Range, Repeat");
/*Dummy data generate karo.*/
// TODO:
// 1. 1 se 10 tak numbers generate karo
// 2. "NA" ko 5 times repeat karo

Console.WriteLine("\nRange.........");
var Range = Enumerable.Range(1, 15);

foreach (var i in Range)
{
    Console.WriteLine(i.ToString());
   
}

Console.WriteLine("\nRepeat.........");
var Repeat = Enumerable.Repeat("NA",5);
foreach(var i in Repeat)
{
    Console.WriteLine(i);

}
#endregion

#region Equality Operator – SequenceEqual

Console.WriteLine("\n\nEquality Operator – SequenceEqual");
/*Do lists same hain ya nahi check karo.*/
// TODO:
// SequenceEqual use karo

var l1 = new List<int>() { 1, 2, 3 };
var l2 = new List<int>() { 1, 2, 3 };

Console.WriteLine("\nSequenceEqual.........");
var Result13 = l1.SequenceEqual(l2);
Console.WriteLine(Result13);
#endregion

#region Set Operations – distinct, Union, Intersect, Except

Console.WriteLine("\n\nSet Operations – Union, Intersect, Except");
/* Roles comparison. */
// TODO:
// 1. Union
// 2. Common roles
// 3. RoleA - RoleB

var roleA = new List<string>() { "Admin", "User", "HR" };
var roleB = new List<string>() { "User", "Finance" };

Console.WriteLine("\nDistinct.........");
var listWords = new List<string>() { "Ved", "Abhi", "Monu", "Lucky", "Ved", "Monu" };
var result1 = listWords.Distinct().ToList();

foreach (var i in result1)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nUnion.........");
var union = roleA.Union(roleB).ToList();

foreach (var record in union)
{
    Console.WriteLine($"{record}");
}

Console.WriteLine("\nIntersect.........");
var Intersect = roleA.Intersect(roleB).ToList();

foreach (var record in Intersect)
{
    Console.WriteLine($"{record}");
}


Console.WriteLine("\nExcept.........");
var Except = roleA.Except(roleB).ToList();

foreach (var record in Except)
{
    Console.WriteLine($"{record}");
}


#endregion

#region Sorting Operators – OrderBy, OrderByDescending
Console.WriteLine("\n\nSorting Operators – OrderBy, OrderByDescending");
/* Sorting Operators – OrderBy, OrderByDescending */
//Numbers ko ascending aur descending order me print karo.

var T4Shorting = new List<int>() { 5, 2, 8, 1, 4 };
var result4 = T4Shorting.OrderBy(x => x).ToList();
var result4_1 = T4Shorting.OrderByDescending(x => x).ToList();

Console.WriteLine("\nShorting ASC.........");
foreach (var i in result4)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nShorting DESC.........");
foreach (var i in result4_1)
{
    Console.WriteLine(i);
}

#endregion

#region Aggregation Operators – Sum, Count, Max, Min, Average
Console.WriteLine("\n\nAggregation Operators – Sum, Count, Max, Min, Average");
/* Aggregation Operators – Sum, Count, Max, Min, Average */
//Salary list se summary nikaalo.

// 1. Total salary
// 2. Highest salary
// 3. Average salary
// 4. Count

var salaries = new List<int>() { 30000, 45000, 60000, 80000 };


Console.WriteLine("\nSum.........");
var sum = salaries.Sum();
Console.WriteLine(sum);

Console.WriteLine("\nMax.........");
var highest = salaries.Max();
Console.WriteLine(highest);

Console.WriteLine("\nAverage.........");
var Average = salaries.Average();
Console.WriteLine(Average);


Console.WriteLine("\nCount.........");
var Count = salaries.Count();
Console.WriteLine(Count);

#endregion

#region Quantifier Operators – Any, All, Contains

Console.WriteLine("\n\nQuantifier Operators – Any, All, Contains");
/* Quantifier Operators – Any, All, Contains */
//Validation checks perform karo.
// TODO:
// 1. Kya koi mark < 35 hai? (Any)
// 2. Kya sab marks >= 60 hai? (All)
// 3. Kya 80 exist karta hai? (Contains)


var marks = new List<int>() { 60, 70, 80, 90 };


Console.WriteLine("\nAny.........");
var Any = marks.Any(x => x < 35);
Console.WriteLine(Any);


Console.WriteLine("\nAll.........");
var All = marks.Any(x => x >= 60);
Console.WriteLine(All);

Console.WriteLine("\nContains.........");
var contains = marks.Contains(80);
Console.WriteLine(contains);

#endregion
