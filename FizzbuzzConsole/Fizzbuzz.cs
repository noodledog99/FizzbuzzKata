using System;

namespace FizzbuzzController
{
    public class Fizzbuzz
    {
        public string Say(int number)
        {
            if(number % 3 == 0 && number % 15 == 0)
            {
                return "FizzBuzz";
            }
            if(number % 5 == 0)
            {
                return "Buzz";
            }
            if(number % 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}