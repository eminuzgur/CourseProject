using CourseProject.Business.Abstract;
using CourseProject.Business.Concrete;
using CourseProject.DataAccess.Concrete.EntityFramework;
using System;

namespace CourseProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDal());
            var result = productService.GetAll();
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
