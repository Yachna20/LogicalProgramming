using System.CodeDom.Compiler;

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
                Console.WriteLine("1.Fibonacci Series\n2.PerfectNumber\n3.PrimeNumber\n4.ReverseNumber" +
                    "\n5.CouponNumber");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Console.WriteLine(" Create Fibonacci Series");
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case  2:
                        PerfectNumber perfect= new PerfectNumber();
                        perfect.Perfect();
                        break;
                    case 3:
                        PrimeNumber prime= new PrimeNumber();
                        prime.Prime();
                        break;
                    case 4:
                        ReverseNumber reverse= new ReverseNumber(); 
                        reverse.Reverse();
                        break;
                    case 5:
                        CouponNumber coup = new CouponNumber();
                        coup.Generate();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}

