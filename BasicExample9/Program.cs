using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample9
{
    // LINQ - Immediate Execution - Anında Çalıştırma
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int i = 0;
            var list = (from sayi in numbers select ++i).ToList();
            // Sorgu bu döngüye gelmeden çalıştırıldığı için aşağıda
            // hep i'nin son aldığı değer (10) çıktıya yazılır.
            foreach (var element in list)
            {
                Console.WriteLine("Sayı = {0}, i = {1}", element, i);
            }
            Console.ReadKey();
        }
    }
}
