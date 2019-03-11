using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample3
{
    //LINQ - Temel İşlemler - Bir Veri Kaynağı Bildirme ve Seçme (From ve Select)
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int No { get; set; }
        }
        static void Main(string[] args)
        {
            //Object initializer list
            var students = new List<Student>
            {
                new Student() { Name = "Ali", Surname = "Ünlü", No = 112 },
                new Student() { Name = "Veli", Surname = "Yeşil", No = 116 },
                new Student() { Name = "Selami", Surname = "Sağlam", No = 132 }
            };

            var query = from student in students
                        select student.Surname;
            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = students.Select(std => std.Surname);
            */
            foreach (var student in query)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
