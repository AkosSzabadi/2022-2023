using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i <= 40; i++)
            {
                Console.Write($"{random.Next(-100, 100)} ");
            }
            Console.ReadKey();
        }
    }
}
