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
                    Console.WriteLine("Out param : " + sum);
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

        private static string SetChoice()
        {
            Console.WriteLine("Please select your path :-");
            Console.WriteLine("***Static Class : Press A");
            Console.WriteLine("***Inheritence  : Press B");
            Console.WriteLine("***Polymorphism : Press C");

            var path = Console.ReadLine();
            return path;
        }

    }
}
