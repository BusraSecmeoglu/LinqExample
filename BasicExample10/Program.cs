using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample10
{
    // LINQ - Query Reuse - Sorgunun Yeniden Kullanımı
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var smallNumber =
                               from number in numbers
                               where number < 5
                               select number;
            Console.WriteLine("İlk çalıştırma sonucunda 5'den küçük sayılar :");
            foreach (int number in smallNumber)
            {
                Console.WriteLine(number);
            }
            // Dizideki sayıları değiştir (negatife çevir)
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = numbers[i] * -1;
            }
            // Sayılar değiştiği için alttaki foreach döngüsünde sorgu tekrar
            // çalıştırılacak ve dolayısıyla farklı sonuçlar görüntülenecektir.
            Console.WriteLine("İkinci çalıştırma sonucunda 5'den küçük sayılar:");
            foreach (int number in smallNumber)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
