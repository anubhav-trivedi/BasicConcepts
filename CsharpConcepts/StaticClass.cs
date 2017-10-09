using System;
using System.Runtime.InteropServices;

namespace CsharpConcepts
{

    // Static classes are more of utility classes and you can directly invoke any funtion.
    public static class StaticClass
    {
        private const float _PI = 3.141F;

        public static void CalculateArea(float rad)
        {
            var area = _PI * rad * rad;
            Console.WriteLine(area);
        }
    }

}
