using System;

namespace CsharpConcepts
{
    class BaseClass : SuperClass
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public BaseClass()
        {
            Console.WriteLine("Executing Base Class constructor");
            _firstName = "Anubhav";
            _lastName = "Trivedi";
        }

        public BaseClass(string fname, string lname)
        {
            Console.WriteLine("Executing Base Class Parameterized constructor");
            _firstName = fname;
            _lastName = lname;
        }

        public string GreetPerson() {
            return "Hello " + (String.IsNullOrEmpty(_firstName) ? "Prachi" : _firstName) + " " + (String.IsNullOrEmpty(_lastName)?"Deshpande" : _lastName);
        }

        public new void GoodBye()
        {
//            base.GoodBye();  // this will invoke base class method
            Console.WriteLine("Goodbye from Base!");
        }
    }
}
