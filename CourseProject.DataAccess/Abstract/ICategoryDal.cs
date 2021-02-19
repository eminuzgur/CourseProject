using Core.DataAccess;
using CourseProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
