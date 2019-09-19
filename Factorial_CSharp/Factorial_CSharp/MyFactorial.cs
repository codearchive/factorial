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

        //public void GetFactorialByRecursion()
        //{
             
        //}

        public long GetFactorialByLoop()
        {
            long factorial = 1;
            while (InputValue != 0)
            {
                factorial *= InputValue;
                InputValue--;
            }

            return factorial;
        }

    }

    
}
