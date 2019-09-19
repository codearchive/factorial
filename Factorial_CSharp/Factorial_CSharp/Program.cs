using System;
using System.Threading;

namespace Factorial_CSharp
{
    public class Program
    {
        public static void Main()
        {
            long inputValueForFactorial = 0;

            MyFactorial firstMyFactorial = new MyFactorial();

            while (true)
            {
                Console.WriteLine("Enter new positive number to calculate factorial or negative number to quit");

                inputValueForFactorial = Int32.Parse(Console.ReadLine());

                if (inputValueForFactorial < 0)
                {
                    break;
                }

                //Thread thread = new Thread(new ThreadStart(firstMyFactorial.GetFactorialByRecursion()));
                //thread.Start()


                firstMyFactorial.InputValue = inputValueForFactorial;
                //firstMyFactorial.GetFactorialByLoop();
                firstMyFactorial.GetFactorialByRecursion();

                Console.WriteLine($"{firstMyFactorial.InputValue}! = {firstMyFactorial.ReturnValue}");
            }
        }
    }
}
