

// Fetch Distinct Numbers from List using LINQ
//var listNumbers = new List<int>() { 1, 3, 4, 5, 2, 2, 2, 0, 6, 7 };
//var DistNumber = listNumbers.Distinct().ToList();

//Console.WriteLine("--------------");

//foreach (var number in DistNumber)
//{
//    Console.WriteLine($"Number is : " + number);
//}

//Console.WriteLine("--------------");



// Fetch Distinct Words from List using LINQ
//var listWords = new List<string>() { "Ved", "Abhi", "Monu", "Lucky", "Ved", "Monu"};
//var DistWords = listWords.Distinct().ToList();

//Console.WriteLine("--------------");
//Console.WriteLine( "Distinct Words are :" );
//foreach (var word in DistWords)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine("--------------");
//Console.ReadLine();



//Filtering

//var Filteringlist = new List<int>() { 1, 3, 4, 5, 2, 2, 2, 0, 6, 7 };
//var even = Filteringlist
//            .Where(x => x % 2 == 0)
//            .Distinct()
//            .ToList();
//var Odd = Filteringlist
//            .Where(x => x % 2 != 0)
//            .Distinct ()
//            .ToList();


//Console.WriteLine("Even Numbers");
//foreach (var number in even)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("Odd Numbers");
//foreach (var number in Odd)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("--------------");
//Console.ReadLine();


// Shorting

var list = new List<int>() { 1, 3, 4, 5, 2, 2, 2, 0, 6, 7 };

var listASC = list
                   .OrderBy(x => x)
                   .Distinct()
                   .ToList();
var listDESC = list
                    .OrderByDescending(x => x)
                    .Distinct()
                    .ToList();

Console.WriteLine("Numbers in Assending:");
foreach (var number in listASC)
{
    Console.WriteLine(number);
}

Console.WriteLine("Numbers in Desending:");
foreach (var number in listDESC)
{
    Console.WriteLine(number);
}