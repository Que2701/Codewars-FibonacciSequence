namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(fib(10));
        }

        public static int fib(int n)
        {
            int previousNumber = 0, currentNumber = 1, nextNumber = 0;
            for (int i = 1; i < n; i++)
            {
                nextNumber = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }
            // your code here!
            return nextNumber;
        }
    }
}
