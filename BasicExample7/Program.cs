using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample7
{
    //LINQ - Temel İşlemler - Birleştirme(Joining)
    class Program
    {
        public class Customer
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string City { get; set; }
        }
        public static List<Customer> GetCustomer()
        {
            //Object initializer list
            List<Customer> Customers = new List<Customer>
            {
               new Customer {Name="Kenan", Surname="Oran", City="Muğla"},
               new Customer {Name="Erhan", Surname="Erkanlı", City="Ankara"},
               new Customer {Name="Ercan", Surname="Orak", City="Ankara"},
               new Customer {Name="Yaşar", Surname="Yılmaz", City="Manisa"}
            };
            return Customers;
        }
        public class Supplier
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string City { get; set; }
        }
        public static List<Supplier> GetSupplier()
        {
            List<Supplier> Suppliers = new List<Supplier>
            {
               new Supplier {Name="Tekin", Surname="Uğurlu", City="Van"},
               new Supplier {Name="Hasan", Surname="Ünlü", City="Ankara"},
               new Supplier {Name="Tuncay", Surname="Çağrı", City="Manisa"},
               new Supplier {Name="Mehmet", Surname="Emre", City="Muğla"}
            };
            return Suppliers;
        }

        static void Main(string[] args)
        {
            List<Customer> customers = GetCustomer();
            List<Supplier> suppliers = GetSupplier();
            var joiningQuery =
                from customer in suppliers
                join supplier in suppliers on customer.City equals supplier.City
                select new
                {
                    City = customer.City,
                    CustomerName = customer.Name,
                    SupplierName = supplier.Name
                };
            // LINQ Yöntem Sözdizimi ile sorgu :
            /*
            var joiningQuery = customers.Join(
                                         suppliers,
                                         customer => customer.City,
                                         supplier => supplier.City,
                                         (customer, supplier) => new { City = customer.City,
                                                                      CustomerName = customer.Name,
                                                                      SupplierName = supplier.Name
                                                                    }
                                                    );
            */
            Console.WriteLine("Şehir, Dağıtıcı - Müşteri");
            Console.WriteLine("-------------------------");
            foreach (var line in joiningQuery)
            {
                Console.WriteLine("{0}, {1} - {2}", line.City,
                                                    line.SupplierName,
                                                    line.CustomerName);
            }
            Console.ReadKey();
        }
    }
}
