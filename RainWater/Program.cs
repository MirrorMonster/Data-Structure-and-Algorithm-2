using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainWater
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int[] Trap(int[] a)
        {
            List<int> totalAmount = new List<int>();
            int[] leftHighest = new int[a.Length + 1];
            leftHighest[0] = 0;
            for(int i = 0; i<a.Length; i++)
            {
                int h = a[i];
                leftHighest[i + 1] = Math.Max(leftHighest[i], h);
            }

            int rightHighest = 0;
            for(int i = a.Length-1; i>=0; i--)
            {
                int h = a[i];
                rightHighest = Math.Max(rightHighest, h);
                if (Math.Min(rightHighest, leftHighest[i]) > h)
                {
                    totalAmount.Add(Math.Min(rightHighest, leftHighest[i]));
                }
                else
                {
                    totalAmount.Add(h);
                }
            }
            totalAmount.Reverse();

          

            return totalAmount.ToArray();
            
        }
    }
}
