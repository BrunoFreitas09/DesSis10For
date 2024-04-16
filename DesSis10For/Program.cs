using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis10For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a =  1; a <= 9; a++) 
            {

                Console.Write(a);
                for (int j = 1; j <= 9; j++)
                {
                    if (a != j)
                    {
                    Console.Write(j);
                    }

                }
                Console.WriteLine("");
            }

               Console.ReadKey();
        }
    }
}
