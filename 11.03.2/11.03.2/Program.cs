using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            string[] name = new string[n];
            //vxod
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi nomer");
                number[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("vuvedi ime");
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("Normalen izhod");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(number[i] + ":" + name[i]);
            }
            //izhod
            Console.WriteLine("Sortirane po nomer");
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = 0; j < number.Length - 1; j++)
                {
                    if (number[j] > number[j] + 1)
                    {
                        int swapVar = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i] + " ");
            }
            //3izxod v nizhodqsht
            for (int i = 0; i < n - 1; i++)
            {

                for (int j = i; j < n - 1 - i; j++)
                {
                    if (number[j] < number[j + 1])
                    {
                        int swapVar12 = number[j];
                        number[i] = number[i + 1];
                        number[i + 1] = swapVar12;
                    }
                }
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(number[j] + " ");
            }
          
            for (int i = 1; i < number.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[j] < number[k])
                        k = j;
                }
                int swapVar12 = number[i];
                number[i] = number[k];
                number[k] = swapVar12;
            }
    Console.WriteLine("sortirane po nomer");
        
            Console.WriteLine(string.Join(" ", number +"," +name));
          
    

                
            
        }
    }
}
