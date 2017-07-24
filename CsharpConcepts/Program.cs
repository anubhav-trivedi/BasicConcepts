using System;

namespace CsharpConcepts
{
    class Program : BaseClass
    {
        static void Main(string[] args)
        {
            string path = SetChoice();
            ProceedOnPath(path);
        }

        private static void ProceedOnPath(string path) 
        {
            switch (path)
            {
                case "A":
                case "a":
                {
                    Console.Write("Enter radius : ");
                    var rad = Console.ReadLine();
                    if (rad != null) StaticClass.CalculateArea(float.Parse(rad));
                }
                    break;

                case "B":
                case "b":
                {
                    Console.WriteLine("Please enter your first name");
                    string a = Console.ReadLine();
                    Console.WriteLine("Please enter your last name");
                    string b = Console.ReadLine();
                    /*
                     * Program pr = new BaseClass() is invalid as Derived class cannot point to Base Class
                     * BaseClass pr = new Program(); is valid as Parent class can point to Derived Class
                     */

                    // Program pr = new Program();
                    BaseClass pr = new BaseClass(a, b);
                    var greeting = pr.GreetPerson();
                    Console.WriteLine(greeting);
                    pr.GoodBye();
                }
                    break;
                case "C":
                case "c":
                {
                    Employee[] employees = new Employee[4];
                    employees[0] = new Employee();
                    employees[1] = new FullTimeEmployee();
                    employees[2] = new PartTimeEmployee();
                    employees[3] = new TemporaryEmployee();

                    foreach (Employee emp in employees)
                    {
                        /*
                         * Using virtual in baseclass we can override the function in derived class.
                         * This is called as Method Overriding or Runtime Polymorphism.
                         * We can also overload method by changing their signatures. 
                         * It is called Method Overloading or Static Polymorphism.
                         */
                        emp.PrintFullName();
                    }
                    float sum;
                    Overload.Add(1, 2);
                    Overload.Add(1, 2, 3);
                    Overload.Add(1.2f, 2, 1);
                    Overload.Add(2.4f, 8, out sum);
                    Console.WriteLine("Out param : {0}", sum);
                }
                    break;
                case "D":
                case "d":
                {
                    int i = 0;
                    float sum;
                    PassByValue(i);  // This will create a copy of i in memory
                    Console.WriteLine("Value of i when passed by Value is " + i);
                    PassByReference(ref i); // This will not create a new copy of i
                    Console.WriteLine("Value of i when passed by Reference is " + i);
                    Overload.Add(2.4f, 8, out sum); // Out parameter is used to return one or more value from method
                    Console.WriteLine("Output parameter is {0}", sum);
                    ParamsMethod(1, 2, 3, 4, 5);
                }
                    break;
                default:
                {
                    Console.WriteLine("******Please enter correct option*******");
                    string newPath = SetChoice();
                    ProceedOnPath(newPath);
                }
                    break;
            }
        }

        private static void PassByReference(ref int i)
        {
            i = 10;
        }

        private static void PassByValue(int i)
        {
            i = 10;
        }

        private static void ParamsMethod(params int[] nums)
        {
            /*
             * Params array parameters are used to pass n number of elements comma separated
             * Params array is also optional
             * Params array must always be last argument you are passing
             */
            Console.WriteLine("I have passed {0} elements", nums.Length);
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
        }

        private static string SetChoice()
        {
            Console.WriteLine("Please select your path :-");
            Console.WriteLine("***Press A : Static Class");
            Console.WriteLine("***Press B : Inheritence");
            Console.WriteLine("***Press C : Polymorphism");
            Console.WriteLine("***Press D : Method Parameters");

            var path = Console.ReadLine();
            return path;
        }

    }
}
