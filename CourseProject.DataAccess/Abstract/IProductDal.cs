using Core.DataAccess;
using CourseProject.Entities.Concrete;
using CourseProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
