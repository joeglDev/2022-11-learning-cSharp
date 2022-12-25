class LoopMethods
{
    public static void runLoops()
    {
        Console.WriteLine("\nRunning programme loops:");

        //if else for decisions as in JS
        // && and || or == equals
        int a = 5;
        int b = 3;
        int c = 4;
        if ((a + b + c > 10) && (a == b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("Or the first number is not equal to the second");
        }

        //while loops check condition is true then execute code
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        }

        //do while loops execute code then check if condition is true
        int counterTwo = 0;
        do
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counterTwo++;
        } while (counterTwo < 10);

        //for loops: initialiser condition iterator
        for (int count = 0; count < 10; count++)
        {
            Console.WriteLine($"Hello World! The counter is {count}");
        }

        //complex examples with nesting and alphabetic iteration
        for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}
    }


}