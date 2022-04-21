using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == entity.ProductId));
                context.SaveChanges();
            }

        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == entity.ProductId);
                productToUpdate.ProductName = entity.ProductName;
                productToUpdate.QuantityPerUnit = entity.QuantityPerUnit;
                productToUpdate.UnitPrice = entity.UnitPrice;
                productToUpdate.UnitsInStock = entity.UnitsInStock;
                productToUpdate.CategoryId = entity.CategoryId;
                context.SaveChanges();
            }
        }
    }

}
