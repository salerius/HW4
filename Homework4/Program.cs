using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            string name = "Andriy";
            FirstTask.DoingFirstTask(name);

            //Second task
            Console.WriteLine(SecondTask.Show(5, 5));
            string text = "55";
            Console.WriteLine(SecondTask.Show(text, 33));

            Console.WriteLine(SecondTask.Greeting("Nataly", 20, "Kiev"));
            Console.WriteLine(SecondTask.Greeting("Olga", "Citrien"));

            Console.WriteLine(SecondTask.CalcAreaSquare(5));
            Console.WriteLine(SecondTask.CalcAreaSquare(5.3));

            Console.WriteLine(SecondTask.CalcAreaTriangle(5, 5));
            Console.WriteLine(SecondTask.CalcAreaTriangle(5.5, 5.5));
            Console.WriteLine(SecondTask.CalcAreaTriangle(5.5, 5));
            Console.WriteLine(SecondTask.CalcAreaTriangle(5, 5.5));

            Console.WriteLine(SecondTask.CalcAreaTrapeze(4, 4, 4));
            Console.WriteLine(SecondTask.CalcAreaTrapeze(4.5, 4.5, 4.5));
            Console.WriteLine(SecondTask.CalcAreaTrapeze(4.5, 4, 4));
            Console.WriteLine(SecondTask.CalcAreaTrapeze(4, 4.5, 4));
            Console.WriteLine(SecondTask.CalcAreaTrapeze(4, 4, 4.5));
            Console.WriteLine(SecondTask.CalcAreaTrapeze(4.5, 4.5, 4));
            Console.WriteLine(SecondTask.CalcAreaTrapeze(4, 4.5, 4.5));
            Console.WriteLine(SecondTask.CalcAreaTrapeze(4.5, 4, 4.5));

            //Third task
            ThirdTask.Nullable();

            //Fourth task
            string nameOfMuvie = "Claud Atlas";
            FourthTask.ShowMuviesInfo(nameOfMuvie);

            string nameOfMyFriend = "Andrii";
            int age = 20;
            FourthTask.ShowMyFriend(nameOfMyFriend, age);

            FourthTask.ShowWeatherForecast(temperature: 15.5, humidity: 70, city: "Khmelnitskiy");
            FourthTask.ShowSoldProducts(profit: 500, quantity: 10, product: "Bread");

            //Fifth task
            int x = 20;
            Console.WriteLine("x before ref :{0}", x);
            FifthTask.RefExemple(ref x);
            Console.WriteLine("x after ref :{0}", x);

            string s = "Kate";
            Console.WriteLine("s before ref :{0}", s);
            FifthTask.RefExemple(ref s);
            Console.WriteLine("s after ref :{0}", s);

            double y;
            FifthTask.OutExemple(out y);
            Console.WriteLine("y after out :{0}", y);

            int z;
            int rezult = FifthTask.OutExemple(out z);
            Console.WriteLine("z after out :{0} and rezult is {1}", z, rezult);

            int[] masFirst = new int[] { 23, 54, 23, 7, 42 };
            FifthTask.ParamsExemple(masFirst);

            string[] masSecond = new string[] { "qwqw", "rere", "cdcd", "gggh" };
            FifthTask.ParamsExemple(masSecond);

            //Sixth task
            Human olga = new Human("Mazur Olga Ivanovna", 25, "woman");
            Human.ShowStructPerson(olga);

            // Seventh task
            var manWoman = Sex.Female;
            SeventhTaskClassEnum person  = new SeventhTaskClassEnum("Mavka Igor Inanovich", 34, manWoman);
            SeventhTaskClassEnum.ShowPerson(person);

            // Eyghth task
            var sexBeing = SexWith.Undefined;
            EyghthTaskClassEnumUndefined being = new EyghthTaskClassEnumUndefined("Fish", 5, sexBeing);
            EyghthTaskClassEnumUndefined.ShowPerson(being);

            var sexBeing1 = SexWith.Male;
            EyghthTaskClassEnumUndefined being1 = new EyghthTaskClassEnumUndefined("Fish", 5, sexBeing1);
            EyghthTaskClassEnumUndefined.ShowPerson(being1);

            //Nine_One
            NineTuples.ShowPersonTuples();
            NineTuples.ShovClassEnumTuples();
            NineTuples.ShowEnumUndefinedTuples();
        }








    }
}
