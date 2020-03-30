using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class NineTuples
    {
        //9.1
        public static void ShowPersonTuples()
        {
            (string, int, string) Human = ("Koval Igor Ivanovich", 35, "male");
            Console.WriteLine("This person is {0}, he is {1} age and he is a {2}", Human.Item1, Human.Item2, Human.Item3);
        }

        //9.2
        public enum Sex
        {
            Female,
            Male
        }

        public static void ShovClassEnumTuples()
        {
            (string, int, Sex) Person = ("Marchuk Ira Viktorovna", 54, Sex.Female);
            Console.WriteLine("This person is {0}, he is {1} age and he is a {2}", Person.Item1, Person.Item2, Person.Item3);
        }

        //9.3
        public enum SexWith
        {
            Undefined,
            Female,
            Male
        }

        public static void ShowEnumUndefinedTuples()
        {
            (string, int, SexWith) Animal = ("Dog", 3, SexWith.Undefined);

            if (Animal.Item3 == SexWith.Undefined)
            {
                Console.WriteLine("This Being is {0}, it is {1} age and we don't know a its sex", Animal.Item1, Animal.Item2);
            }
            else
            {
                Console.WriteLine("This person is {0}, he is {1} age and he is a {2}", Animal.Item1, Animal.Item2, Animal.Item3);
            }
        }
    }
}
