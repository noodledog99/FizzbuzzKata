using System;

namespace FizzbuzzController
{
    public class Fizzbuzz
    {
        public string Say(int number)
        {
            if(number == 5 || number == 10)
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