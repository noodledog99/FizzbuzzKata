using System;
using System.IO;
using System.Linq;
using FizzbuzzController;

namespace FizzbuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {   
            var filePath = "./number.txt";
            if(!File.Exists(filePath))
            {
                using(StreamWriter file = new StreamWriter(filePath))
                {
                    foreach (var number in Enumerable.Range(1,100))
                    {
                        file.WriteLine(number);
                    }
                }
            }

           var readFile = File.ReadAllLinesAsync(filePath);
           var fizzbuzz = new Fizzbuzz();
           var result = string.Empty;

           foreach (var line in readFile.Result)
           {
               result = fizzbuzz.Say(Convert.ToInt32(line));
               System.Console.WriteLine($"{line} = {result}");
           }
        }
    }
}
