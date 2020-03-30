using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class ThirdTask
    {
        public static void Nullable()
        {
            int? x = null;
            double? d = 5.2;
            bool? b = true;

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
                Console.WriteLine("x is null");

            if (d.HasValue)
            {
                Console.WriteLine(d.Value);
            }
            else
                Console.WriteLine("x is null");

            if (b.HasValue)
            {
                Console.WriteLine(b.Value);
            }
            else
                Console.WriteLine("b is null");
        }
    }
}
