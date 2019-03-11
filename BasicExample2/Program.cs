using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample2
{
    // Bir onceki örneğin yöntem sözdizimi ile yazılmış hali şöyledir. 
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 1, 3, 33, 44, 56, 101 };

            //listenin içinde dönüyor ve sayıların tek olanları getirir.
            var odds = list.Where(number => number % 2 == 1);

            foreach (var oddNumber in odds)
            {
                Console.WriteLine(oddNumber);
            }
            Console.ReadKey();
        }
    }
}
