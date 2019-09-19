using System;

namespace Factorial_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyFactorial firstMyFactorial = new MyFactorial(5);
            MyFactorial secondFactorial = new MyFactorial();

            Console.WriteLine($"{firstMyFactorial.InputValue}! = {firstMyFactorial.GetFactorialByLoop()}");
            Console.WriteLine($"{secondFactorial.InputValue}! = {secondFactorial.GetFactorialByLoop()}");
        }
    }
}
