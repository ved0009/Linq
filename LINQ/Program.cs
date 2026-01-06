

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
//var list = new List<int>() { 1, 3, 4, 5, 2, 2, 2, 0, 6, 7 };

//var listASC = list
//                   .OrderBy(x => x)
//                   .Distinct()
//                   .ToList();
//var listDESC = list
//                    .OrderByDescending(x => x)
//                    .Distinct()
//                    .ToList();

//Console.WriteLine("Numbers in Assending:");
//foreach (var number in listASC)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("Numbers in Desending:");
//foreach (var number in listDESC)
//{
//    Console.WriteLine(number);
//}


// First or firstOrDefault Or LastOrDefault

var list = new List<int>() { 1, 3, 5,  7 };

var FirstVariable = list.First();
Console.WriteLine(FirstVariable.ToString());

try
{

var ErroredVariable = list
                      .Where(x => x % 2 == 0)
                      .First();
// Here SecondVariable result is 0 or null because there is no { 1, 3, 5,  7 } even number in list so it Gives Exception of System.InvalidOperationException: 'Sequence contains no elements'
// To resolve this We have firstOrDefault
}
catch (Exception ex)
{
    Console.WriteLine($"Exception Occurs: " + ex.Message.ToString());
}

//firstOrDefault

var FixedVariable = list
                      .Where(x => x % 2 == 0)
                      .FirstOrDefault();

Console.WriteLine(FixedVariable.ToString());

var LastVariable = list
                      .LastOrDefault();

Console.WriteLine(LastVariable.ToString());
