namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(2, 3);
            Add(0.2m, 0.8m);
            Add(1, 1, true);
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static void Add(int a, int b, bool isTrue)
        {
            var sum = a + b;
            if (isTrue == true && sum > 1)
            {
                Console.WriteLine($"{sum} dollars");
            }
            else if (isTrue == true && sum == 1)
            {
                Console.WriteLine($"{sum} dollar");
            }
            else if (isTrue == true && sum < 1)
            {
                Console.WriteLine($"{sum} dollars");
            }
        }
    }
}
