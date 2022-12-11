namespace LogicalProgramming
{
    public class Program
    {

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Logical Programming Problems");
                Console.WriteLine("1.Fibonacci Series");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Console.WriteLine(" Create Fibonacci Series");
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}

