using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public enum Sex
    {
        Female,
        Male
    }

    class SeventhTaskClassEnum
    {
        public string pip;
        public int age;
        public Sex sex;

        public SeventhTaskClassEnum(string pip, int age, Sex sex)
        {
            this.pip = pip;
            this.age = age;
            this.sex = sex;
        }

        public static void ShowPerson(SeventhTaskClassEnum imya)
        {
            Console.WriteLine("This person is {0}, he is {1} age and he is a {2}", imya.pip, imya.age, imya.sex);
           // Console.WriteLine(imya.pip);
        }     
    }
}
