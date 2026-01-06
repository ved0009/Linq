  

        // Fetch Distinct Numbers from List using LINQ
        var listNumbers = new List<int>() { 1, 3, 4, 5, 2, 2, 2, 0, 6, 7 };
        var DistNumber = listNumbers.Distinct().ToList();

        Console.WriteLine("--------------");

        foreach (var number in DistNumber)
        {
            Console.WriteLine($"Number is : " + number);
        }

        Console.WriteLine("--------------");
        Console.ReadLine();

 



 