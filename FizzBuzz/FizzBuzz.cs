using System;
using System.Collections.Generic;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {

        }

        public static List<String> GetFizzBuzzList(int ceiling)
        {
            var fizzBuzzNumbers = new List<String>();

            for (int i = 1; i <= ceiling; i++)
            {
                fizzBuzzNumbers.Add(GetNextNumber(i));
            }

            return fizzBuzzNumbers;
        }

        private static String GetNextNumber(int i)
        {
            bool divisibleByThree = ((i % 3) == 0);
            bool divisibleByFive = ((i % 5) == 0);

            if (divisibleByThree && divisibleByFive)
            {
                return "FizzBuzz";
            }
            else if (divisibleByFive)
            {
                return "Buzz";
            }
            else if (divisibleByThree)
            {
                return "Fizz";
            }
            else
            {
                return i.ToString();
            }
        }
    }

}
