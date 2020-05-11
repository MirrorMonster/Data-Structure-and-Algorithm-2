using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion3
    {
        public static void Run()
        {
            Console.WriteLine(Ex7(123, 0));
        }

        /// <summary>
        /// tính tổng từ 1 tới n, đầu vào n: int
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Ex1(int n)
        {
            if (n == 1) return 1;
            return n + Ex1(n - 1);
        }

        public static long Ex2(long n)
        {
            if (n == 1) return 1;
            return n * n + Ex2(n - 1);

        }
        public static float Ex3(int n)
        {
            if (n == 1) return 1;
            return 1.0f / n + Ex3(n - 1);
        }

        public static float Ex4(float x, float n)
        {
            if (n == 0) return 1;
            return x * Ex4(x, n - 1);
        }

        public static int Ex6(int a, int b)
        {
            if (b == 0) return a;
            return Ex6(b, a % b);
        }

        public static int Ex5(int n)
        {
            if (n % 2 != 0) return n;
            return Ex5(n / 2);
        } 

        public static int Ex7(int n, int count)
        {
            if (n == 0) return count;
            count++;
            return Ex7(n/10, count);
        }

        public static double Ex8(int n,int c)
        {
            if (c == n) return Math.Sqrt(n);
            return Math.Sqrt(c + Ex8(n - 1,c+1));
        }

    }
}
