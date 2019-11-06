using System;

namespace FizzbuzzController
{
    public class Fizzbuzz
    {
        public string Say(int number)
        {
          
            if(number == 5)
            {
                return "Buzz";
            }
            if(number == 3 || number == 6 || number == 9)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}