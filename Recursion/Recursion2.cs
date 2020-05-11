using System;

namespace Recursion
{
    class Recursion2
    {
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

        public static float Ex3(float x, int n)
        {
            if (n == 1)
                return x;
            return x * Ex3(x, n - 1);
        }

        public static int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return Gcd(b, a % b);
        }

        
    }
}
