using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[int.Parse(Console.ReadLine())];
            string arrf = "asdasda*&^&%%#$%^#$^&*(()IHNBFRTI&*(-**--%$&*IB^&CF#@/--+sda";
            Random rnd = new Random();
            for (int i = 0; i < arrf.Length; i++)
            {
               Console.WriteLine(rnd.Next(arr.Length));
                Console.WriteLine( arrf[i]);
            }
            Console.ReadLine();
        }
    }
}
