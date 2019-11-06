using System;

namespace FizzbuzzController
{
    public class Fizzbuzz
    {
        public string Say(int number)
        {
            if(number == 3)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}