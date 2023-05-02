using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Hutton_Riley
{
    static class Calculate
    {


        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        //INTEGERS

        //Adding two integers and returns the result
        public static int Add(int x, int y)
        {
            return x + y;
        }

        //Subtracts two integers and returns the result
        public static int Sub(int x, int y)
        {
            return x - y;
        }

        //Multiplies two integers and returns the result
        public static int Mult(int x, int y)
        {
            return x * y;
        }

        //Divides two integers and returns the result
        public static int Div(int x, int y)
        {
            return x / y;
        }

        //FLOATERS

        //Adds two floaters and returns the result
        public static float Add(float x, float y)
        {
            return x + y;
        }

        //Subtracts two floaters and returns the result
        public static float Sub(float x, float y)
        {
            return x - y;
        }

        //Multipies two floaters and returns the result
        public static float Mult(float x, float y)
        {
            return x * y;
        }

        //Divides two floaters and returns the result
        public static float Div(float x, float y)
        {
            return x / y;
        }

    }
}
