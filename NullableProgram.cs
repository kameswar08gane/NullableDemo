using System;

namespace NullableDemo
{
    class NullableProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int? num1 = 20;
            int? num2 = null;

            double? num3 = 3.14;
            double? num4 = new double?();

            bool? boolval = new bool?();

            Console.WriteLine("num1: {0},num2: {1}, Num3: {2}, Num4: {3}",num1,num2,num3,num4);
            Console.WriteLine("BoolValue",boolval);

            Console.ReadLine();
        }
    }
}
