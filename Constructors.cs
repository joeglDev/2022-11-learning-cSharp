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
            Console.WriteLine($"Yip yap merp, my name is {this.name}.");
        }


    }


    //inheritance from Parent
    class Shigu : Sergal
    {
        //new properties
        public bool loyalty;
        // constructor of derived class
        public Shigu(string name, int age, bool loyalty) : base(name, age)
        {
            // DerivedClass parameter types have to match base class types
            // Do additional work here otherwise you can leave it empty
            this.loyalty = loyalty;
        }

        //polymorphic method
        new public void introduceYourself()
        {
            Console.WriteLine($"You dare summon me? I am {this.name}.");
        }
    }



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

        Shigu rain = new Shigu("Rain Silves", 30, true);
        Console.WriteLine($"{rain.name} is loyal to the Shigu: {rain.loyalty}.");
        rain.introduceYourself();
    }
}