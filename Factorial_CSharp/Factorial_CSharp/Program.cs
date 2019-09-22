using System;
using System.Diagnostics;
using System.Threading;

namespace Factorial_CSharp
{
    public class Program
    {
        public static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";

            MyFactorial objMyFactorial = new MyFactorial();

            while (objMyFactorial.InputValue < 20)
            {
                Thread secondThread = new Thread(new ParameterizedThreadStart(objMyFactorial.GetFactorialByLoop))
                {
                    Name = "Second thread"
                };
                secondThread.Start(secondThread.Name);
                Thread.Sleep(100);
                objMyFactorial.GetFactorialByLoop(t.Name);
                Console.WriteLine(Process.GetCurrentProcess().Threads.Count);
            }

            Console.ReadLine();
        }
    }
}
