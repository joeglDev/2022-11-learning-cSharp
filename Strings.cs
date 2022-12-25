


    class StringMethods
    {
        public static void runStrings(string[] args)
        {
            //new lines
            Console.WriteLine("Program runs");
            Console.WriteLine("This is the first line.");

            //continue old line
            Console.Write("This is ");
            Console.Write("the second ");
            Console.Write("line.");

            //include vars
            string name = "Hiroji";
            Console.WriteLine($"\n Hello, my name is {name}");

            //string properties exist e.g.
            int lettersInName = name.Length;
            Console.WriteLine($"There are {lettersInName} letters in the name {name}.");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            //contains ? return bool
            string contains = "Merp merp merp";
            bool containsMerp = contains.Contains("merp");
            bool containsYap = contains.Contains("yap");
            Console.WriteLine($"{containsMerp} {containsYap}");

            //user inputs
            //string? input;
            //input = Console.ReadLine();
            // Console.WriteLine($"You typed into the console: {input}.");

        }
    }
