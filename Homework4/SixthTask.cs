using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{

    struct Human
    {
        public string pip;
        public int age;
        public string sex;

        public Human(string pip, int age, string sex)
        {
            this.pip = pip;
            this.age = age;
            this.sex = sex;
        }

        public static void ShowStructPerson(Human imya)
        {
            Console.WriteLine("This person is {0}, he is {1} age and he is a {2}", imya.pip, imya.age, imya.sex);
        }
    }
}
