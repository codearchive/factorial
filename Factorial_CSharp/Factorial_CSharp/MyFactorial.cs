using System;

namespace Factorial_CSharp
{
    public class MyFactorial
    {
        public long InputValue { get; set; }

        public long ReturnValue { get; set; }

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

        public void GetFactorialByRecursion()
        {
            ReturnValue = recurFunc(InputValue);
        }

        public void GetFactorialByLoop()
        {
            long localValue = InputValue;
            while (localValue != 0)
            {
                ReturnValue *= localValue;
                localValue--;
            }
        }

        private static readonly Func<long, long> recurFunc = x =>
        {
            if (x == 0) return 1;
            return x * recurFunc(x - 1);
        };
    }
}
