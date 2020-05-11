using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E
{
    class Program
    {
        public delegate double ExpHandle(double x, int n);
        static void Main(string[] args)
        {
            Console.WriteLine(Timer(ExpX1, 2.5, 100000));
            Console.WriteLine(Timer(ExpX2, 2.5, 100000));
            Console.ReadLine();
            
        }



        public static string Timer(ExpHandle fn, double x, int n) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            fn(x, n);
            stopwatch.Stop();
            return stopwatch.Elapsed.ToString();
        }

        public static double ExpX1(double x, int n)
        {
            double s = 1;
            for (int i = 1; i <=n; i++)
            {
                int gt = 1;
                for (int j = 1; j <= i; j++)
                {
                    gt *= j;
                   
                }
                s += Math.Pow(x, i)/gt;
            }
            return s;
        }

        public static double ExpX2(double x, int n)
        {
            double s = 1;
            int gt = 1;
            for(int i=1; i<=n; i++)
            {
                gt *= i;
                s += Math.Pow(x, i) / gt;
            }
            return s;
        }
    }

    
}
