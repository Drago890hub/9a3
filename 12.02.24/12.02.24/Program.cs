using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kolko dushi shte vuvejdash");
          int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            double[] djobni = new double[n];  
            
            //vhod
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine("vuvedi ime i familiq");
                name[i] = Console.ReadLine();
               
Console.WriteLine("vuvedi kolko djobni shte imash");
                djobni[i]= double.Parse(Console.ReadLine());
                
            }
            //izxod1
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine(name[i] + "ime" + djobni[i]+"leva");
            }
            //izxod2

            for (int i = 0; i < n; i++)
            {
                if (djobni[i] ==7)
                Console.WriteLine(name[i] + "ime" + djobni[i] + "leva");

            }
            //izxod3
            for (int i = 0; i < n; i++)
            {
                int banica = int.Parse(Console.ReadLine());
                    Console.WriteLine(name[i] + "ime" +( djobni[i] - banica) + "leva");

            }

        }
    }
}
