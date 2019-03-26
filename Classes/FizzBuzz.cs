using System;

namespace HelloWorld.Classes
{
    public class FizzBuzz
    {
        public void DoFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                var multipleOfThree = i % 3 == 0;
                var multipleOfFive = i % 5 == 0;

                if (multipleOfThree && multipleOfFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (multipleOfThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (multipleOfFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}