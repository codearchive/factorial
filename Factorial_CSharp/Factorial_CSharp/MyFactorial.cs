namespace Factorial_CSharp
{
    public class MyFactorial
    {
        public int InputValue { get; set; }

        public MyFactorial(int value)
        {
            InputValue = value;
        }

        public MyFactorial()
        {
            InputValue = 0;
        }

        public void GetFactorialByRecursion()
        {
            
        }

        public int GetFactorialByLoop()
        {
            int factorial = 1;
            while (InputValue != 0)
            {
                factorial *= InputValue;
                InputValue--;
            }

            return factorial;
        }

    }

    
}
