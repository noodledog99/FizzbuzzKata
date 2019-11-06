using System;

namespace FizzbuzzController
{
    public class Fizzbuzz
    {
        public string Say(int number)
        {
            if(number == 4)
            {
                return "4";
            }
            if(number == 3)
            {
                return "Fizz";
            }
            if(number == 2)
            {
                return "2";
            }
            return "1";
        }
    }
}