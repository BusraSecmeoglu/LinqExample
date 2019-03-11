using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples_DataSource
{
    // Öğrenci kaydı olarak kullanılan sınıf...
    public class Register
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Class { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int Club { get; set; }
        public int[] Notes { get; set; }
        public double Average { get; set; }
        public bool Success { get; set; }
        public int NumberOfBooksRead { get; set; }
    }

    // Club kaydı olarak kullanılan sınıf...
    public class ClubRegister
    {
        public int RegisterNo { get; set; }
        public string Name { get; set; }
        public string Responsible { get; set; }
    }


    public class ClassSource
    {
        // Öğrenci kaydı tutan Kayit isimli sınıfın bir listesini döndüren yöntem...
        public static List<Register> GetStudents()
        {
            List<Register> Students = new List<Register>();
            Students.Add(new Register()
            {
                No = 2,
                Name = "Tuncay",
                Surname = "Çağrı",
                Gender = "Erkek",
                DateOfBirth = new DateTime(2002, 2, 27),
                Class = 4,
                Club = 0,
                NumberOfBooksRead = 11,
                Notes = new int[] { 75, 70, 75 }
            });
            Students.Add(new Register()
            {
                No = 4,
                Name = "Jale",
                Surname = "İkinci",
                Gender = "Bayan",
                DateOfBirth = new DateTime(1970, 1, 28),
                Class = 3,
                Club = 1,
                NumberOfBooksRead = 7,
                Notes = new int[] { 100, 95, 97, 96 }
            });
            Students.Add(new Register()
            {
                No = 7,
                Name = "Tekin",
                Surname = "Uğurlu",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1955, 3, 26),
                Class = 1,
                Club = 1,
                NumberOfBooksRead = 4,
                Notes = new int[] { 30, 40, 20 }
            });
            Students.Add(new Register()
            {
                No = 8,
                Name = "Mesut",
                Surname = "Bahtiyar",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1980, 4, 25),
                Class = 4,
                Club = 1,
                NumberOfBooksRead = 8,
                Notes = new int[] { 70, 10, 30 }
            });
            Students.Add(new Register()
            {
                No = 12,
                Name = "Veli",
                Surname = "Canlı",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1993, 5, 24),
                Class = 4,
                Club = 2,
                NumberOfBooksRead = 8,
                Notes = new int[] { 80, 40, 10 }
            });
            Students.Add(new Register()
            {
                No = 6,
                Name = "Ahmet",
                Surname = "Geçe",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1958, 6, 23),
                Class = 2,
                Club = 2,
                NumberOfBooksRead = 9,
                Notes = new int[] { 70, 80, 80 }
            });
            Students.Add(new Register()
            {
                No = 15,
                Name = "Fatma",
                Surname = "Teyze",
                Gender = "Bayan",
                DateOfBirth = new DateTime(1972, 7, 22),
                Class = 3,
                Club = 1,
                NumberOfBooksRead = 12,
                Notes = new int[] { 70, 98, 97, 92 }
            });
            Students.Add(new Register()
            {
                No = 14,
                Name = "Mehmet",
                Surname = "Emre",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1970, 8, 21),
                Class = 4,
                Club = 0,
                NumberOfBooksRead = 7,
                Notes = new int[] { 80, 22, 97 }
            });
            Students.Add(new Register()
            {
                No = 3,
                Name = "Hale",
                Surname = "Birinci",
                Gender = "Bayan",
                DateOfBirth = new DateTime(1982, 9, 20),
                Class = 2,
                Club = 1,
                NumberOfBooksRead = 11,
                Notes = new int[] { 20, 40, 10, 30 }
            });
            Students.Add(new Register()
            {
                No = 13,
                Name = "Ayşe",
                Surname = "Hanım",
                Gender = "Bayan",
                DateOfBirth = new DateTime(1983, 10, 19),
                Class = 2,
                Club = 1,
                NumberOfBooksRead = 5,
                Notes = new int[] { 100, 40, 100 }
            });
            Students.Add(new Register()
            {
                No = 11,
                Name = "Cevdet",
                Surname = "Döğer",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1967, 11, 18),
                Class = 3,
                Club = 2,
                NumberOfBooksRead = 7,
                Notes = new int[] { 20, 0, 30, 15 }
            });
            Students.Add(new Register()
            {
                No = 1,
                Name = "Nuri",
                Surname = "Babayiğit",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1998, 12, 17),
                Class = 2,
                Club = 2,
                NumberOfBooksRead = 6,
                Notes = new int[] { 55, 75, 65 }
            });
            Students.Add(new Register()
            {
                No = 5,
                Name = "Kenan",
                Surname = "Oran",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1961, 1, 16),
                Class = 1,
                Club = 0,
                NumberOfBooksRead = 9,
                Notes = new int[] { 50, 70, 80 }
            });
            Students.Add(new Register()
            {
                No = 9,
                Name = "Lale",
                Surname = "Üçüncü",
                Gender = "Bayan",
                DateOfBirth = new DateTime(1990, 2, 15),
                Class = 3,
                Club = 0,
                NumberOfBooksRead = 6,
                Notes = new int[] { 20, 0, 30 }
            });
            Students.Add(new Register()
            {
                No = 10,
                Name = "Erhan",
                Surname = "Erkanlı",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1958, 3, 14),
                Class = 1,
                Club = 1,
                NumberOfBooksRead = 7,
                Notes = new int[] { 90, 90, 90, 90 }
            });
            Students.Add(new Register()
            {
                No = 16,
                Name = "Erhan",
                Surname = "Fidan",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1968, 4, 13),
                Class = 2,
                Club = 1,
                NumberOfBooksRead = 8,
                Notes = new int[] { 95, 70, 100, 80 }
            });
            Students.Add(new Register()
            {
                No = 17,
                Name = "Erhan",
                Surname = "Çelik",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1978, 5, 12),
                Class = 3,
                Club = 1,
                NumberOfBooksRead = 7,
                Notes = new int[] { 90, 55, 90 }
            });

            foreach (var Student in Students)
            {
                Student.Average = Student.Notes.Average();
                Student.Success = Student.Average >= 55;
                Student.Age = DateTime.Now.Year - Student.DateOfBirth.Year;
            }

            return Students;

        }

        // Kulüp kaydı tutan ClubRegister isimli sınıfın bir listesini döndüren yöntem.
        public static List<ClubRegister> ClubleriGetir()
        {
            List<ClubRegister> Clubs = new List<ClubRegister>();
            Clubs.Add(new ClubRegister() { RegisterNo = 0, Name = "Gezi", Responsible = "Tanju Bülbül" });
            Clubs.Add(new ClubRegister() { RegisterNo = 1, Name = "Tiyatro", Responsible = "Metin Öztürk" });
            Clubs.Add(new ClubRegister() { RegisterNo = 2, Name = "Müzik", Responsible = "Nuri Sezer" });
            Clubs.Add(new ClubRegister() { RegisterNo = 3, Name = "Kitap", Responsible = "Kazım Ünlüol" });
            return Clubs;
        }
    }
}

