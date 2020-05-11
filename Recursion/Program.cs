using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Recursion
{
    class Program
    {
        public delegate int HandleIntRecursion(int n);
        public delegate long HandleLong(int n);

        static void Main(string[] args)
        {
            Backtracking.Run();
            Console.ReadLine();
        }

        public static void Timer(HandleIntRecursion fn, int n)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            fn(n);
            st.Stop();
            Console.WriteLine(st.Elapsed.ToString());
            Console.WriteLine("_____________________");
        }

        public static void Timer(HandleLong fn, int n)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            fn(n);
            st.Stop();
            Console.WriteLine(st.Elapsed.ToString());
            Console.WriteLine("_____________________");
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        public static long Sum(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + Sum(n - 1);
        }

        public static int SumByForLoop(int n)
        {
            int sum = 0;
            for(int i =1; i<=n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int FactorialByForLoop(int n)
        {
            int fact = 1;
            for(int i =1; i<=n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public static long Fib(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }

  
        public static long FibByLoop(int n)
        {
            long s = 1;
            long past = 1;
            for(int i =3; i<=n; i++)
            {
                s = s + past;
                past = s - past;
            }
            return s;
        }


        public static void HanoiTower(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine(A + "==>" + C);
            
            }
            else
            {
                HanoiTower(n - 1, A, C, B);
                Console.WriteLine(A + "==>" + C);
                HanoiTower(n - 1, B, A, C);
            }
        }

        public static int Ex1(int n)
        {
            if (n == 1)
                return 1;
            return n * n + Ex1(n - 1);
        }

        public static float Ex2(int n)
        {
            if (n == 1)
                return 1;
            return (float)1 / n + Ex2(n - 1);
        }

        public static float  Ex3(float x, int n)
        {
            if (n == 1)
                return x;
            return x * Ex3(x,n - 1);
        }

        public static int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return Gcd(b, a % b);
        }
    }

    
    
    

}
