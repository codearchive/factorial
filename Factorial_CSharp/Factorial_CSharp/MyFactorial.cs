namespace Factorial_CSharp
{
    public class MyFactorial
    {
        public long InputValue { get; set; }

        public MyFactorial(long value)
        {
            InputValue = value;
        }

        public MyFactorial()
        {
            InputValue = 0;
        }

        public long GetFactorialByRecursion(long value)
        {
            if (value == 0) return 1;
            return value * GetFactorialByRecursion(value - 1);
        }

        public long GetFactorialByLoop()
        {
            long factorial = 1;
            long localValue = InputValue;
            while (localValue != 0)
            {
                factorial *= localValue;
                localValue--;
            }

            return factorial;
        }
    }
}
