using System;

namespace Factorial_CSharp
{
    public class Program
    {
        public static void Main()
        {
            long InputValueForFactorial = 0;
            MyFactorial firstMyFactorial = new MyFactorial();
            while (true)
            {
                Console.WriteLine("Enter new positive number to calculate factorial or negative number to quit");
                InputValueForFactorial = Int32.Parse(Console.ReadLine());
                if (InputValueForFactorial < 0)
                {
                    break;
                }
                firstMyFactorial.InputValue = InputValueForFactorial;
                Console.WriteLine($"{firstMyFactorial.InputValue}! = {firstMyFactorial.GetFactorialByLoop()}");
            }
        }
    }
}
