using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Recursion
{
    class Backtracking
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n+1];
            int[] s = new int[n+1];
            x[0] = 1;
            
            NumberAnalys(n, 1, x, s);

        }
        public static void BinaryCombination(int i, int n, int[] x)
        {
            for (int val = 0; val < 2; val++)
            {
                x[i] = val;
                if (i >= n - 1)
                {
                    foreach (var v in x)
                        Console.Write(v);
                    Console.WriteLine();
                }
                else BinaryCombination(i + 1, n, x);
            }

        }

        public static void NumberAnalys(int n, int i, int[] x, int[] sum)
        {
            for (int j = x[i - 1]; j <= (n - sum[i - 1]); j++)
            {
                x[i] = j;
                sum[i] = sum[i - 1] + j;
                if (sum[i] == n)
                {
                    for (int t = 1; t <= i; t++)
                        Console.Write(x[t]);
                    Console.WriteLine();
                }
                else
                    NumberAnalys(n, i + 1, x, sum);
            }

        }

        public static void NumberAnalys(int n, int i, int[] x, int[] sum, int[] xi)
        {
            for (int j = xi[i - 1]; j <= n - sum[i - 1]; j++)
            {
                x[i] = j;
                sum[i] = sum[i - 1] + j;
                if (sum[i] == n)
                {
                    for (int c = 1; c <= i; c++)
                        Console.Write(x[c] + "+");
                    Console.WriteLine();
                }
                else NumberAnalys(n, i + 1, x, sum, xi);

            }
        }

        public static void NumberAnalys2(int n, int i, int[] s, int[] x)
        {
            for (int j = 0; j < s.Length; j++)
            {
                x[i] = s[j];
                if (x[i - 1] < x[i])
                {
                    int sum = 0;
                    for (int f = 0; f <= i; f++)
                        sum += x[f];
                    if (sum == n)
                        Print(x, i);
                    if (i < s.Length)
                        NumberAnalys2(n, i + 1, s, x);
                }
                else x[i] = 0;
            }
        }
        public static void Print(int[] a, int n)
        {
            for (int i = 1; i <= n; i++)
                Console.Write(a[i]);
            Console.WriteLine();
        }
        // mảng s đã được sắp xếp
        public static void Permutation(int i, int[] s, int[] x)
        {
            for (int j = 0; j < s.Length; j++)
            {
                x[i] = s[j];
                if (x[i - 1] < x[i])
                {
                    Print(x, i);
                    if (i < s.Length)
                        Permutation(i + 1, s, x);

                }
                else x[i] = 0;
            }
        }


        

    }   
}
