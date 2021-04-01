using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Παρακαλώ δώστε έναν αριθμό: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ο αριθμός Fibonacci είναι το νούμερο: {Fibonacci(n)}");
            Console.ReadKey();
        }

        private static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
