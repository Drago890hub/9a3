using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi danni");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for(int i = n-1; i < number.Length; i--) 
            {
                Console.WriteLine(number[i]);   
                number[i] = int.Parse(Console.ReadLine());

            }

        }
    }
}
