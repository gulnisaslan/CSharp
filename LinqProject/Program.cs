using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId= 1, CategoryName="Bilgisayar"},
                new Category{CategoryId= 2, CategoryName="Kitap"}
            };
            List<Product> products = new List<Product>
            {
                new Product { ProductId=1,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 gb",UnitPrice=5000,UnitsInStock=10},
                new Product { ProductId=1,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 gb",UnitPrice=15500,UnitsInStock=10},
                new Product { ProductId=2,CategoryId=2,ProductName="Çöle inen nur ",QuantityPerUnit="Necip Fazıl Kısakürek",UnitPrice=30,UnitsInStock=10},
                new Product { ProductId=3,CategoryId=1,ProductName="MAcOS Laptop",QuantityPerUnit="M1 işlemcili Bilgisayar",UnitPrice=15500,UnitsInStock=10},
                new Product { ProductId=1,CategoryId=2,ProductName="Faydasız Randevu",QuantityPerUnit="İsmet Özel",UnitPrice=45,UnitsInStock=10}
            };
            var result = from p in products
                         join c in categories on p.CategoryId equals c.CategoryId
                         select new ProductDTO { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0}------ {1}",productDto.ProductName ,productDto.CategoryName);
            }




           // ClassicLinqTest(products);
            //AscDesc(products);
            //  FindAllTest(products);
            //  FindTest(products);
            //AnyTest(products);
            // LinqExercises(products);
            // GetProduct(products);
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 30
                         orderby p.UnitPrice descending, p.UnitPrice ascending
                         select new ProductDTO
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice
                         };


            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDesc(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice > 5000);
            var result1 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer");
            Console.WriteLine(result);
        }

        private static void LinqExercises(List<Product> products)
        {
            Console.WriteLine("*******algoritmik****************");
            foreach (var product in products)
            {
                if (product.UnitPrice >= 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }


            Console.WriteLine("*******Linq****************");
            var result1 = products.Where(product => product.UnitPrice >= 5000 && product.UnitsInStock >= 3);
            foreach (var item in result1)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        static List<Product> GetProduct(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice >= 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
      static  List<Product> GetProductsLinqt(  List<Product> products)
      {
         return   products.Where(product=>product.UnitPrice>=5000&& product.UnitsInStock>=3).ToList();
       }
    }
    
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
  
    
    class ProductDTO
    {
        public int ProductId { get; set; }
        public string  CategoryName { get; set; }
        public string  ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
//ilişkisel tasarımdır 
