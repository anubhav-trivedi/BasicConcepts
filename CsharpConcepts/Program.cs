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
                {
                    Console.Write("Enter radius : ");
                    var rad = Console.ReadLine();
                    if (rad != null) StaticClass.CalculateArea(float.Parse(rad));
                }
                    break;

                case "B":
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
                {

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
