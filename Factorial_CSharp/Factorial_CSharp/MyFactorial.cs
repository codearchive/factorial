using System;

namespace Factorial_CSharp
{
    public class MyFactorial
    {
        public long InputValue { get; set; }

        public long ReturnValue { get; set; }

        private object x = new object();

        public MyFactorial(long value)
        {
            InputValue = value;
            ReturnValue = 1;
        }

        public MyFactorial()
        {
            InputValue = 0;
            ReturnValue = 1;
        }

        public void GetFactorialByRecursion(object threadName)
        {
            ReturnValue = RecurFunc(InputValue);
            Console.WriteLine($"{(string)threadName}:\t {InputValue}! = {ReturnValue}");
            lock (x)
            {
                InputValue++;
            }
        }

        public void GetFactorialByLoop(object threadName)
        {
            ReturnValue = 1;
            long localValue = InputValue;
            while (localValue != 0)
            {
                ReturnValue *= localValue;
                localValue--;
            }

            Console.WriteLine($"{(string)threadName}:\t {InputValue}! = {ReturnValue}");
            lock (x)
            {
                InputValue++;
            }
        }

        private static readonly Func<long, long> RecurFunc = x =>
        {
            if (x == 0) return 1;
            return x * RecurFunc(x - 1);
        };
    }
}
