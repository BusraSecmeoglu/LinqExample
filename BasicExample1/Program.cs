using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample1
{
    //LINQ (Language Integrated Query - Dile Entegre Edilmiş Sorgu) Nedir?
//    LINQ Sağlayıcıları(LINQ Providers)
//LINQ yazımızda, LINQ ile farklı türdeki verileri sorgulayabileceğinizi belirtmiştik.Farklı ortamlarda bulunan verileri sorgulamak için LINQ Sağlayıcıları denilen farklı LINQ kütüphaneleri kullanılır.

//Bunlar;

//- Hafızadaki IEnumerable<T> arayüzünü uygulayan nesneleri sorgulamak için kullanılan "LINQ to Objects",

//- XML belgelerini XElement koleksiyonuna çevirerek LINQ komutlarının kullanımına imkan tanıyan "LINQ to XML" (XLINQ),

//- SQL Server Veritabanları ve SQL Server Compact Veritabanları üzerinde LINQ ile sorgulama yapmamızı sağlayan "LINQ to SQL" (DLINQ),

//- ADO.NET Datasetlerden sorgulama yapmanızı, dolayısıyla ADO.NET'in kullanabildiği tam XML desteği dahil tüm veritabanlarını sorgulamanızı sağlayan "LINQ to Datasets"

//- ADO.NET Entity Framework tarafından oluşturulan varlıkları sorgulamak için "LINQ to Entity"

    class Program
    {
        static void Main(string[] args)
        {
            //Array elemanlarini veritabani tablosu gibi sorgulayabiliyoruz
            var array = new int[] { 1, 3, 33, 44, 56, 101 };

            var odds =
                         from number in array
                         where number % 2 == 1
                         select number;

            foreach (var oddNumber in odds)
            {
                Console.WriteLine(oddNumber);
            }

            Console.ReadKey();

        }
    }
}
