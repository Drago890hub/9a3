using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _8._04._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi ime");
            string str = "Hello ,Drago v C#";
            Console.WriteLine("kak ti e imeto");
            string name = Console.ReadLine();
            Console.WriteLine("Hi," + name);

            Console.WriteLine("Kak ti e prezimeto");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hi,{0} {1}",name , lastname);

            Console.WriteLine("kak ti e familiata");
            string family = Console.ReadLine();
            Console.WriteLine($"Hi{name},{lastname},{family}!");

            int result = string.Compare(name, lastname, true);
            Console.WriteLine(result);

            string str1 = string.Concat(name,family, lastname);
            Console.WriteLine(str1);

      
            int firstIndex = name.IndexOf(",");
            Console.WriteLine(firstIndex);
            int secondIndex = name.IndexOf("d",1);
 Console.WriteLine(secondIndex);
            int notFound = name.IndexOf("");
           
            Console.WriteLine(notFound);
            string name1 = str.Substring(1, 8);
            Console.WriteLine(name1);
            string replaced = name1.Replace("v C#", "otiva");
            Console.WriteLine(replaced);
        }
    }
}
