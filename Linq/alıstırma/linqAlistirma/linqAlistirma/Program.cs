using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace linqAlistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categoryList = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar" },
                new Category{CategoryId=2, CategoryName="Telefon" },
                new Category{CategoryId=3, CategoryName="Bilgisayar Aksesuarları" }
            };
            List<Product> ProductList = new List<Product>
            {
                new Product{PId=1, CategoryId=1, PName="ABC Laptop",PropertyofUnit="16 GB Ram", UnitPrice=3500,UnitsInStock=10},
                new Product{PId=2, CategoryId=2, PName="QWE Telefon",PropertyofUnit="4 GB Ram", UnitPrice=1500,UnitsInStock=500},
                new Product{PId=3, CategoryId=3, PName="123 Kulaklık",PropertyofUnit="HiFi ", UnitPrice=200,UnitsInStock=1000 },
                new Product{PId=4, CategoryId=2, PName="QWEWRT Telefon",PropertyofUnit="8 GB Ram", UnitPrice=2500,UnitsInStock=285},
                new Product{PId=5, CategoryId=1, PName="ASD Laptop",PropertyofUnit="64 GB Ram", UnitPrice=7500,UnitsInStock=0}
            };

            Console.WriteLine("Kara düzen");
            Console.WriteLine("*************");
            GetProducts(ProductList);

            Console.WriteLine("-------Linq'li düzen-------");
            Console.WriteLine("___________________");
            GetProductsLinq(ProductList);
            Console.WriteLine("*************");

            //var sonuc = ProductList.Where(y => y.UnitPrice > 2000 && y.UnitsInStock < 250);

            //foreach (var item in sonuc)
            //{
            //    Console.WriteLine(item.PName);
            //}

            var deneme = from x in ProductList where x.PName.Equals("ASD Laptop") && x.UnitPrice==7500 select x;

            foreach (var qwq in deneme)
            {
                Console.WriteLine("*//--- Urunun ismi: "+qwq.PName+" Urunun ozelligi: "+qwq.PropertyofUnit+" Stokta su kadar: "+qwq.UnitsInStock+"---//*");
            }
          
        }
        static List<Product> GetProducts(List<Product> ProductList)
        {
            List<Product> istenilenProducts = new List<Product>();
            foreach (var x in ProductList)
            {
                if (x.UnitPrice > 2000 && x.UnitsInStock < 350)
                {
                    istenilenProducts.Add(x);
                    Console.WriteLine(x.PName);///döngüde kullanılan değeri nesne olarak kullan örn burada 'x'
                }
            }
            return istenilenProducts;
        }
        static List<Product> GetProductsLinq(List<Product> ProductList)
        {
            var istenilenProductsLinq= ProductList.Where(y => y.UnitPrice > 2000 && y.UnitsInStock < 250).ToList();//ToList eklenerek Ienumlar listeye çevrilir. 
            foreach (var aaa in istenilenProductsLinq)
            {
                Console.WriteLine(aaa.PName);
            }
            return istenilenProductsLinq;         
        }
    }

    class Product
    {
        public int PId { get; set; }
        public int CategoryId { get; set; }
        public string PName { get; set; }
        public string PropertyofUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}