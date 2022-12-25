class NumberMethods
{
    public static void runNumbers()
    {
        Console.WriteLine("Numbers runs: ");

        // + = * / arithmetic operators
        //e.g.

        int a = 1;
        int b = 4;
        int c = a + b;
        Console.WriteLine($"A + B = {c}");

        //WARNING: integer devision produces an integer result

        int aa = 7;
        int ba = 4;
        int ca = 3;
        int d = (aa + ba) / ca;

        //remainder with %
        int e = (a + b) % c;
        Console.WriteLine($"quotient: {d}");
        Console.WriteLine($"remainder: {e}");

        //int has min and max values
        //leads to underflow and overflow values
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} to {max}");
        //errors will wrap around e.g.
        int what = max + 3;
        Console.WriteLine($"An example of overflow: {what}");

        /*
The double numeric type represents a double-precision floating point number. 
Those terms may be new to you. A floating point number is useful to represent 
non-integral numbers that may be very large or small in magnitude. 
Double-precision is a relative term that describes the numbers of binary digits used to store the value. 
Double precision numbers have twice the number of binary digits as single-precision. 
On modern computers, it is more common to use double precision than single precision numbers. 
Single precision numbers are declared using the float keyword. Let's explore. 
Try the following code in the interactive window and see the result:
        */

        //decomals have smaller range but greater precision than doubles
        decimal minDec = decimal.MinValue;
        decimal maxDec = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {minDec} to {maxDec}");

        //The M suffix on the numbers is how you indicate that a constant should use the decimal type.
        // Otherwise, the compiler assumes the double type.
        double radius = 2.50;
        double area = radius * radius * Math.PI;
        Console.WriteLine(area);

    }
}