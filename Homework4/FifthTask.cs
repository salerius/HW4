using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class FifthTask
    {
        public static void RefExemple(ref int x)
        {
            x = x + 10;
        }

        public static void RefExemple(ref string s)
        {
            s = s + " Hello";
        }

        public static void OutExemple(out double v)
        {
            v=25.4;
        }

        public static int OutExemple(out int m)
        {
            m = 144;
            return m + 144;
        }

        public static void ParamsExemple(params int[] array)
        {
            for (int i = 0; i<array.Length;i++)
            {
                Console.Write(array[i]+ " ");
            }
            Console.WriteLine();
        }

        public static void ParamsExemple(params string[] array)
        {
                Console.WriteLine(array[2]);
        }
    }
}
