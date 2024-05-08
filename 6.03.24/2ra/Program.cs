using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi chisla");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            for(int i = 0;i<n; i++) 
            {
                sum += (arr[i]*i);  // sum = sum + (arr[i]*i)
              
            }
            Console.WriteLine(sum);
         
        }
    }
}
