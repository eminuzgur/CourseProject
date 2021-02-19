using Core.Utilities.Result;
using CourseProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
