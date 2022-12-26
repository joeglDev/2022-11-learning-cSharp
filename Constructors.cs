class ConstructorMethods
{

    //define a new class
    class Sergal
    {

        public string name;
        public int age;
        // Create a class constructor with multiple parameters
        public Sergal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //methods
        public void introduceYourself()
        {
            Console.WriteLine($"You dare summon me? I am {this.name}.");
        }


    }


    //inheritance from Parent
   


    public static void runConstructors()
    {
        Console.WriteLine("\nRunning program Constructors:");

        Sergal hiroji = new Sergal("Hiroji", 25);
        Console.WriteLine(hiroji.age);
        //edit property
        hiroji.age = 15;
        Console.WriteLine(hiroji.age);

        //call method
        hiroji.introduceYourself();

       // Shigu Rain = new Shigu("Rain Silves", 30);
    }
}