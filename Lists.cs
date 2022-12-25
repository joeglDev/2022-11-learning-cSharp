class ListMethods
{
    public static void runLists()
    {
        Console.WriteLine("\nRunning Programme Lists: ");

        //simple iteration of a list
        var names = new List<string> { "<name>", "Ana", "Felipe" };
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }

        //add and remove names elements
        names.Add("Hiroji");
        names.Remove("Ana");
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }

        //lists have methods and can be accessed by element index
        Console.WriteLine($"The list has {names.Count} people in it and I am {names[2]}.");

        //search lists for element of goven index: returns -1 if not found
        var index = names.IndexOf("Felipe");
        if (index != -1)
            Console.WriteLine($"The name {names[index]} is at index {index}");

        var notFound = names.IndexOf("Not Found");
        Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

        //sort method
        names.Sort();
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }

        //numbers
        var fibonacciNumbers = new List<int> { 1, 1 };
        for (int i = 1; i < 19; i++)
        {
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);
        }


        foreach (var item in fibonacciNumbers)
            Console.WriteLine($"{item}, {fibonacciNumbers.Count}");

    }
}