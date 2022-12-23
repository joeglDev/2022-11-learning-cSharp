// See https://aka.ms/new-console-template for more information

//create programme dotnet new console -o MyApp -f net7.0
// run dotnet run

using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
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

        }
    }
}
/*
//variables
//int number = 1;
//const float Pi = 3.14f;

// camelCase -> local var
//PascalCase -> pascal case

//basic C# types
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String

// non primitive
string
array
enum
class


//can use var keyword to let C# compiler interpret datatype from var
Overflowing

byte number = 255;
soppose
number = number + 1; -> 0 as too large

prevent with check keword
checked {
    var declarations
    aithmatic operations
}

Scope


*/



