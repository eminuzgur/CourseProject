﻿using Core.Utilities.Result;
using CourseProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int id);
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
