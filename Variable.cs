class Variable
{
    static void Main(string[] args)
    {
        // Declare a variable to hold an integer value
        int myNumber;

        // Assign a value to the variable
        myNumber = 10;

        // Declare and initialize a variable to hold a decimal value
        double decimalNumber = 25.00;

        // Declare and initialize a variable to hold a boolean value
        bool isCSharpFun = true;

        // Declare and initialize a variable to hold a character value
        char symbol = '@';

        // Declare and initialize a variable to hold a string value
        String name = "Manideep Pilli";


        // Print the value of the variable to the console
        Console.WriteLine("The value of myNumber is: " + myNumber);
        Console.WriteLine("The value of decimalNumber is: " + decimalNumber);
        Console.WriteLine("Is C# fun? " + isCSharpFun);
        Console.WriteLine("The symbol is: " + symbol);
        Console.WriteLine("My name is: " + name);



        // constant = a variable whose value cannot be changed
        const double PI = 3.14;
        Console.WriteLine("The value of PI is: " + PI);


        //Type casting - converting one data type to another

        double doubleNumber = 42.00; 
        int intNumber = (int)doubleNumber; // Explicit casting from double to int
        Console.WriteLine("The value of intNumber is: " + intNumber);

        //Printing the type of a variable
        Console.WriteLine("The type of myNumber is: " + myNumber.GetType());

        // Converting int to string
        String val = Convert.ToString(myNumber);



        // Getting user input
        Console.WriteLine("Enter your age: ");
        String age = Console.ReadLine();
        Console.WriteLine("Your age is: " + age);


        /****         Arithmetic operations         ****/

         int friends = 5;

            friends = friends + 1;
        //friends += 1;
        //friends++;

        //friends = friends - 1;
        //friends -= 1;
        //friends--;

        //friends = friends * 2;
        //friends *= 2;

        //friends = friends / 2;
        //friends /= 2;

        //int remainder = friends % 2;
        //Console.WriteLine(remainder);

        Console.WriteLine(friends);
            
        
         /****         Math Class         ****/
        double x = 3;
        double y = 5;

        double a = Math.Pow(x, 2);
        double b = Math.Sqrt(x);
        double c = Math.Abs(x);
        double d = Math.Round(x);
        double e = Math.Ceiling(x);
        double f = Math.Floor(x);
        double g = Math.Max(x, y);
        double h = Math.Min(x, y);

        Console.WriteLine(a);


        /****         Random Number         ****/

        Random rand = new Random();
        int randomNum = rand.Next(1, 100); // Generates a random number between 1 and 99
        Console.WriteLine("Random number: " + randomNum);


        /****         String  Methods         ****/
        String fullName = "Bro Code";
        String phoneNumber = "123-456-7890";

        //fullName = fullName.ToUpper();
        //fullName = fullName.ToLower();
        //Console.WriteLine(fullName);

        //phoneNumber = phoneNumber.Replace("-","");
        //Console.WriteLine(phoneNumber);

        //String userName = fullName.Insert(0,"Mr.");
        //Console.WriteLine(userName);

        //Console.WriteLine(fullName.Length);

        String firstName = fullName.Substring(0, 3);
        String lastName = fullName.Substring(4, 4);

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);


        /****         If Else Statements         ****/

         //if statement = a basic form of decision making

        Console.WriteLine("Please enter your name: ");
        String nameif = Console.ReadLine();

        if (nameif == "")
        {
            Console.WriteLine("You did not enter your name!");
        }
        else
        {
            Console.WriteLine("Hello " + nameif);
        }



        /****         Switch Statements         ****/

         // switch = an efficient alternative to many else if statements

            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("It's Monday!");
                break;
            case "Tuesday":
                Console.WriteLine("It's Tuesday!");
                break;
            case "Wednesday":
                Console.WriteLine("It's Wednesday!");
                break;
            case "Thursday":
                Console.WriteLine("It's Thursday!");
                break;
            case "Friday":
                Console.WriteLine("It's Friday!");
                break;
            case "Saturday":
                Console.WriteLine("It's Saturday!");
                break;
            case "Sunday":
                Console.WriteLine("It's Sunday!");
                break;
            default:
                Console.WriteLine(day + " is not a day!");
                break;
        }
            
        /****         While Loops         ****/    

        // while loop = repeats some code while some condition remains true

        String newName = "";

        while (newName == "")
        {
            Console.Write("Enter your newName: ");
            newName = Console.ReadLine();
        }
            

        Console.WriteLine("Hello " + newName);


        /****         For Loops         ****/

        // for loop = repeats some code a certain number of times

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Iteration " + i);
        }

        /****         Array         ****/


        // array = a variable that can store multiple values. fixed size

        //String[] cars = {"BMW", "Mustang", "Corvette"};

        String[] cars = new string[3];
            

        cars[0] = "Tesla";
        cars[1] = "Mustang";
        cars[2] = "Corvette";


        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }



        /****         foreach loop         ****/

        foreach (String cara in cars)
        {
            Console.WriteLine(cara);
        }



        /****         Methods         ****/

        // method  = performs a section of code, whenever it's called "invoked".
        //           benefit = Let's us reuse code w/o writing it multiple times
        //           Good practice is to capitalize method names (I forgot in this video)

        String nameMethod = "Bro";
        int ageMethod = 21;


        SingHappyBirthday(nameMethod, ageMethod);


        /****         Method Parameters         ****/
        //params keyword = a method parameter that takes a variable number of arguments.
        //The parameter type must be a single - dimensional array

        double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
            

        Console.WriteLine(total);

        Console.ReadKey();



        // exception = errors that occur during execution

        //        try     = try some code that is considered "dangerous"
        //        catch   = catches and handles exceptions when they occur
        //        finally = always executes regardless if exception is caught or not

        int xExec;
        int yExec;
        double result;


        try
        {
            Console.Write("Enter number 1: ");
            xExec = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            yExec = Convert.ToInt32(Console.ReadLine());

            result = xExec / yExec;

            Console.WriteLine("result: " + result);
        }
        catch (FormatException exec)
        {
            Console.WriteLine("Enter ONLY numbers PLEASE!");
        }
        catch (DivideByZeroException exec)
        {
            Console.WriteLine("You can't divide by zero! IDIOT!");
        }
        catch (Exception exec)
        {
            Console.WriteLine("Something went wrong!");
        }
        finally
        {
            Console.WriteLine("Thanks for visiting!");
        }

        
        /****         Static keyword         ****/
        // static = modifier. makes a member belong to the type itself rather than to a specific object.
        //          means you can access a member without creating an instance of the class first.

        // static = modifier to declare a static member, which belongs to the class itself
        //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);
        Car.StartRace();


        /****         Inheritance        ****/
        // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

        Car1 car = new Car1();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();


        Console.WriteLine(car.speed);
        Console.WriteLine(car.wheels);
        car.go();


        Console.WriteLine(bicycle.speed);

        Console.WriteLine(bicycle.wheels);
        bicycle.go();
            

        Console.WriteLine(boat.speed);
        Console.WriteLine(boat.wheels);
        boat.go();


            
    }


    static void SingHappyBirthday(String birthdayBoy, int yearsOld)
    {
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday dear " + birthdayBoy);
        Console.WriteLine("You are " + yearsOld + " years old!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine();
    }


    static double CheckOut(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }

    //getters & setters = add security to fields by encapsulation
            // They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)


            // auto-Implemented property =  shortcut when no additional logic is required in the property
            //                                you do not have to define a field for a property,
            //        
            


    class Car
    {
        String model { get; set; }
        private int speed;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public int Speed
        {
            get { return speed; }
            set                   
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }



        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }  



     class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }

           public override string ToString()
        {       
            return "This is the speed of the Vehicle" + speed ;
        }
    }
    class Car1 : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }




    /*
    Abstract Methods and Classes:
No Implementation:
An abstract method has no implementation in the base class. It only declares the method signature.
Must Override:
Any non-abstract derived class must provide an implementation for all inherited abstract methods using the override keyword. If a derived class does not implement an abstract method, it must also be declared abstract.
Abstract Classes:
A class containing one or more abstract methods must itself be declared abstract. Abstract classes cannot be instantiated directly.
Purpose:
Abstract methods enforce a contract, ensuring that all concrete derived classes provide a specific behavior.


Virtual Methods:
Default Implementation: A virtual method has a default implementation in the base class.
Optional Override: Derived classes can override a virtual method to provide a specialized implementation using the override keyword, but it is not mandatory. If a derived class does not override, the base class implementation is used.
Concrete Classes: virtual methods can exist in both abstract and concrete classes.
Purpose: virtual methods provide a default behavior that can be customized by derived classes. 

    */


// interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             Benefit = security + multiple inheritance + "plug-and-play"
    interface IPrey
    {
        void Flee();
    }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }
    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    } 
        
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}