using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strong type ( string int fload/bouble bool )
            string name = "POonnapop";

            int year = 19;

            double weight = 100;

            float version = 1.0f;

            bool isstuden = true;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I'm " + year + " year old");
            Console.WriteLine(weight + " KG");
            Console.WriteLine("app version" + version);
            Console.WriteLine(isstuden);
            //-------------------------------------------------------------//
            Console.WriteLine("Hello what is your name");
            string input = Console.ReadLine();
            Console.WriteLine("hello ,"+input+",nice to meet you" );
            //-------------------------------------------------------------//
            Console.WriteLine("How old are you?");
            string ageinput = Console.ReadLine();
            Console.WriteLine("Oh " + ageinput + " so your birhtday is");
            //-------------------------------------------------------------//   
            int birthYear = 0;
            try
            {
                int age = int.Parse(ageinput);
                birthYear = DateTime.Now.Year - age;
                Console.WriteLine("oh " + ageinput + " so your birthday is in " + birthYear);
            }
            catch (Exception ex)
            {
                Console.WriteLine("your input wrong number");
                return;
            }
            //-------------------------------------------------------------//
            Console.WriteLine("Waht Gen you are");
            if (birthYear >= 2013)
            {
                Console.WriteLine("you are Gen Alpha");
            }
            else if (birthYear >= 1997 && birthYear <= 2012)
            {
                Console.WriteLine("you are Gen Z");
            }
            else if (birthYear >= 1981 && birthYear <= 1996)
            {
                Console.WriteLine("you are Gen Y (Millennial)");
            }
            else if (birthYear >= 1965 && birthYear <= 1980)
            {
                Console.WriteLine("you are Gen X");
            }
            else
            {
                Console.WriteLine("you die bro");
            }


        }
    }
}
