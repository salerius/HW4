using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class FourthTask
    {
        public static void ShowMuviesInfo(string name, string category = "Comedy", int year = 2015)
        {
            Console.WriteLine("I watched the muvie, it was {0}, {1}, {2}", name, category, year);
        }

        public static void ShowMyFriend(string name, int age, string driverLicense = "Bike")
        {
            Console.WriteLine("I have a friend his name is {0}, he is {1} age, and he has a drive licens on the {2}", name, age, driverLicense);
        }

        public static void ShowWeatherForecast(string city, double temperature, int humidity)
        {
            Console.WriteLine("The Weather forecast in {0}  - temperature:{1}, humidity:{2}", city, temperature, humidity);
        }

        public static void ShowSoldProducts(int quantity,  string product, int profit)
        {
            Console.WriteLine("Tuday I sold {0} quantity {1} and got profit is {2}", quantity, product, profit);
        }

    }
}
