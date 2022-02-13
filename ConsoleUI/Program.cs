using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product1 in productManager.GetAll())
            {
                //Console.WriteLine(product.ProductName);
            }

            foreach (var product2 in productManager.GetAllByCategoryId(6))
            {
                //Console.WriteLine(product2.ProductName);
            }

            foreach (var product3 in productManager.GetByUnitPrice(10,50))
            {
                Console.WriteLine(product3.ProductName + " : " + product3.UnitPrice);
            }
        }
    }
}
