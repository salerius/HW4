using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{

    public enum SexWith
    {
        Undefined,
        Female,
        Male
    }

    class EyghthTaskClassEnumUndefined
    {
        public string kind;
        public int age;
        public SexWith sex;

        public EyghthTaskClassEnumUndefined(string kind, int age, SexWith sex)
        {
            this.kind = kind;
            this.age = age;
            this.sex = sex;
        }

        public static void ShowPerson(EyghthTaskClassEnumUndefined imya)
        {
            if (imya.sex == SexWith.Undefined)
            {
                Console.WriteLine("This Being is {0}, it is {1} age and we don't know a its sex", imya.kind, imya.age);
            }
            else
            {
                Console.WriteLine("This person is {0}, he is {1} age and he is a {2}", imya.kind, imya.age, imya.sex);
            }
        }
    }
}
