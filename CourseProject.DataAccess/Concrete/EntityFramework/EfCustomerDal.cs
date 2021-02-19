using Core.DataAccess.EntityFramework;
using CourseProject.DataAccess.Abstract;
using CourseProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,NorthwindContext>,ICustomerDal
    {
    }
}
