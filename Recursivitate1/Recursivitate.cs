using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate1
{
    public static class Recursivitate
    {
        public static void Parcurgere(int[] v, int n)
        {
            if (n == 1)
                Console.WriteLine(v[n-1]);
            else 
            {
                Parcurgere(v, n - 1);
                Console.WriteLine(v[n]);
            }
        }
    }
}
