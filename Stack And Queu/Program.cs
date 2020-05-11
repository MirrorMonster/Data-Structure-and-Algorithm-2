using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_And_Queu
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            CustomStack stack = new CustomStack();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                stack.Push(n % 2);
                n /= 2;
            }
        
            stack.Show();
            Console.WriteLine();

            while (!stack.IsNullable())
            {
                Console.Write(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}
