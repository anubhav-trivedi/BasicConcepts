using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts
{
    public class Employee
    {
        public string FName = "Anubhav";
        public string LName = "Trivedi";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FName + " " + LName);
        }

    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FName + " " + LName + " is a Full Time employee");
        }
 
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FName + " " + LName + " is a Part Time employee");
        }
        
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FName + " " + LName + " is a Temporary employee");
        }

    }

}
