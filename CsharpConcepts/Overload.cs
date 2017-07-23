using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts
{
    static class Overload
    {
        /*
         * We can overload a method based upon number, type and kind (value, ref, out)
         * of parameters. 
         * We cannot overload using Return type or using params modifier
         */
        public static void Add(int a, int b)
        {
            Console.WriteLine("Sum is {0}", a + b);
        }

        public static void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum is {0}", a + b + c);
        }

        public static void Add(float a, int b, int c)
        {
            Console.WriteLine("Sum is {0}", a + b + c);
        }

        public static void Add(float a, int b, out float sum)
        {
            sum = a + b;
        }
    }
}
