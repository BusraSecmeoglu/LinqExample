using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples_DataSource;

namespace BasicExample4
{
    //LINQ - Temel İşlemler - Süzme (Filtering)
    class Program
    {
        static void Main(string[] args)
        {
            List<Register> students = ClassSource.GetStudents();

            //(1. yazılı sınav notu 55 ve daha büyük olan öğrencilerin soyadlarını seç.)
            var query = from student in students
                        where student.Notes[0] >= 55
                        select student.Surname;
            foreach (var s in query)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

            /*  //LINQ Yöntem Sözdizimi ile sorgu :
             var query = students.Where(std => std.Notes[0] >= 55)
                                   .Select(ogr => ogr.Surname);
             */

            Console.WriteLine("---------------");

            var query2 = from student in students
                         where student.Notes[0] >= 55 && student.Success == false
                         select student;
            foreach (var s in query2)
            {
                Console.WriteLine(s.Surname);
            }
            Console.ReadKey();

            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = students.Where(std => std.Notes[0] >= 55 && ogr.Success == false);
            */
        }
    }
}
