using System;
using HelloWorld.Classes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.DoFizzBuzz();
            Console.ReadLine();
        }
    }
}
