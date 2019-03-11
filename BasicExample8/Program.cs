using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample8
{
    // LINQ - Deferred Execution - Ertelenmiş Çalıştırma
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int i = 0;
            var query =
                       from n in numbers
                       select ++i;
            // Burada ertelenmiş çalıştırmanın bir yan etkisi olarak,
            // i değişkeninin değeri de her bir eleman foreach içinde
            // kullanıldığında (döngü içinde) arttırılacaktır.
            foreach (var m in query)
            {
                Console.WriteLine("biri = {0}, i = {1}", m, i);
            }

            Console.WriteLine("Ikinci dongu sirasinda i kaldigi yerden devam ediyor:");
            i = 90;
            foreach (var m in query)
            {
                Console.WriteLine("biri = {0}, i = {1}", m, i);
            }

            Console.ReadKey();
        }
    }
}
