using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class FirstTask
    {

        public static void DoingFirstTask(string massages)
        {
            //Exemple with string array
            string[] toys = new string[] { "cup", "book", "pan" };
            Console.WriteLine("{0}, you bought three things : {1}, {2}, {3}", massages, toys[0], toys[1], toys[2]);

            //Exemple with int array
            int[] priceOfBread = new int[] { 12, 14, 8, 15, 6 };
            int summ = 0;
            int mean;
            for (int i = 0; i < priceOfBread.Length; i++)
            {
                summ = summ + priceOfBread[i];
            }
            mean = summ / priceOfBread.Length;
            Console.WriteLine("The prices of bread is different but mean price is {0}", mean);

            //Exemple with char array
            char[] nameOfLeters = new char[6];
            nameOfLeters[0] = 'A';
            nameOfLeters[1] = 'n';
            nameOfLeters[2] = 'd';
            nameOfLeters[3] = 'r';
            nameOfLeters[4] = 'i';
            nameOfLeters[5] = 'i';
            Console.Write("Your name is : ");
            for (int j = 0; j < nameOfLeters.Length; j++)
            {
                Console.Write(nameOfLeters[j]);
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} leters in your names", nameOfLeters.Length);
        }
    }
}
