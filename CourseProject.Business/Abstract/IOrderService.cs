using Core.Utilities.Result;
using CourseProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int id);
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }
}
