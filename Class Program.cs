using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71A_WeekTwo_ChallengeGold
{
    public class Class1
    {
        //Challenge 1. Create Greeter
        public class Greeter
        { 
        //Challenge 1. Build a method that takes in a name as a parameter and outputs hello to that person
        public void Hello(string name) 
        {
            Console.WriteLine($"Hello Charles");
        }
        
        //Challenge 2. Build another method that outputs some sort of farewell to the name it's given as a parameter
        public void Farewell(string name) 
        {
            Console.WriteLine($"Farewell Charles");
        }

        //Challenge 3.  Build a method that outputs Good Morning/Afternoon/Evening
        public void TimeOfDay() 
        {
            int TimeOfDay = DateTime.Now.Hour;

            if (TimeOfDay >= 0 && TimeOfDay < 12) 
            {
                Console.WriteLine("Good Morning!");
            }
            else if (TimeOfDay >=12 && TimeOfDay < 18) 
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if (TimeOfDay >=18 && TimeOfDay < 20) 
            {
                Console.WriteLine("Good Evening!");
            }
            else if (TimeOfDay >=20 && TimeOfDay < 23) 
            {
                Console.WriteLine("Good Night!");
            }
            }
        }

       
        

        //Challenge 4. New up an instance of your greeter class inside your main.  Calling all methods built out
        static void Main(string[] args) 
        {
            Greeter greeter = new Greeter();
            Console.WriteLine("Please, type your name");
            string name = Console.ReadLine();
            greeter.Hello(name);
            greeter.TimeOfDay();
            greeter.Farewell(name);
            Console.ReadLine();

        }

    }
}
