using System;

namespace Static_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs the integers for the calculations

            //Integers
            Console.WriteLine("Integer Methods");
            Console.WriteLine(Calculate.Add(73, 26));
            Console.WriteLine(Calculate.Sub(48, 42));
            Console.WriteLine(Calculate.Mult(12, 16));
            Console.WriteLine(Calculate.Div(81, 9));

            //Inputs the Floaters for the calculations

            //FLOATERS
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine(Calculate.Add(73.14f, 26.46f));
            Console.WriteLine(Calculate.Sub(48.45f, 42.75f));
            Console.WriteLine(Calculate.Mult(12.12f, 16.53f));
            Console.WriteLine(Calculate.Div(81.49f, 9.7f));

        }
    }
}
