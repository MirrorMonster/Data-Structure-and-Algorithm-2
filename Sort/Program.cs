using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        public delegate void Sorting(List<int> a);
        static void Main(string[] args)
        {

            //Timer(SelectionSort, GenerateList(100, 100));
            Timer(BubbleSort, GenerateList(100, 100));
            //Timer(InsertionSort, GenerateList(100, 100));
            Console.WriteLine("___________________________");
            //Timer(SelectionSort, GenerateList(1000, 1000));
            Timer(BubbleSort, GenerateList(1000, 1000));
            //Timer(InsertionSort, GenerateList(1000, 1000));
            Console.WriteLine("____________________________");
            //Timer(SelectionSort, GenerateList(10000, 10000));
            Timer(BubbleSort, GenerateList(10000, 10000));
            //Timer(InsertionSort, GenerateList(10000, 10000));

            Console.ReadLine();

            string s = "";
            char[] a = s.ToCharArray();
            

        }

        public static void Timer(Sorting fn, List<int> a)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            fn(a);
            st.Stop();
            Console.WriteLine(st.Elapsed.ToString());
        }

        public static List<int> GenerateList(int n, int maxVal)
        {
            List<int> a = new List<int>();
            Random r = new Random();
            for(int i=0; i<n; i++)
            {
                a.Add(r.Next(maxVal));
            }
            return a;
        }

        public static void BubbleSort(List<int> a)
        {
            for(int i =0; i<a.Count()-1; i++)
            {
                for(int j = i+1; j<a.Count(); j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }

        public static void SelectionSort(List<int> a)
        {
            for(int i=0; i<a.Count()-1; i++)
            {
                int min = i;
                for(int j =i+1; j<a.Count(); j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int t = a[i];
                    a[i] = a[min];
                    a[min] = t;
                }
            }
        }


        public static void InsertionSort(List<int> a)
        {
            int pos, x;
            for(int i=1; i< a.Count(); i++)
            {
                x = a[i];
                for(pos = i; (pos>0) && (a[pos-1]>x); pos--)
                {
                    a[pos] = a[pos - 1];
                }
                a[pos] = x;
            }
        }
    }
}
