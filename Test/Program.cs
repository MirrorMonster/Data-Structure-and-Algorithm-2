using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }

        bool CheckStrongPassword(string password)
        {
            if (password.Length >= 0)
            {
                int d = 0;
                foreach(char a in password)
                {
                    if (char.IsDigit(a)) ;
                }
            }
            return true;
        }
    } 
}
