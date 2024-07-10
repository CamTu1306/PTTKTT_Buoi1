using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            int n = a.Length; 

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("Tong cac phan tu trong mang la: " + sum);
        }
    }
}
