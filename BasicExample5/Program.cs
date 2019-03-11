using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples_DataSource;

namespace BasicExample5
{
    //LINQ - Temel İşlemler - Sıralama (Ordering)
    class Program
    {
        static void Main(string[] args)
        {
            List<Register> students = ClassSource.GetStudents();

            // Bu örnek, 1.yazılı sınav notu 55 ve daha büyük olan öğrencileri 
            //1.sınav notlarına göre artan sırada(küçükten büyüğe) seçer.
            var query = from student in students
                        where student.Notes[0] >= 55
                        orderby student.Notes[0]
                        select student;

            foreach (var student in query)
            {
                Console.WriteLine(student.Name);
            }

            Console.ReadKey();
            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = students.Where(std => std.Notes[0] >= 55)
                                  .OrderBy(std => std.Notes[0]);
            */
            Console.WriteLine("---------------");

            //Eğer tersine bir sıralama isteniyorsa descending ifadesi 
            //cümleciğin sonuna eklenir.
            var query2 = from student in students
                         where student.Notes[0] >= 55
                         orderby student.Notes[0] descending
                         select student;

            foreach (var student in query2)
            {
                Console.WriteLine(student.Name);
            }

            Console.ReadKey();
            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = students.Where(std => std.Notes[0] >= 55)
                                  .OrderByDescending(std => std.Notes[0]);
            */

        }
    }
}
