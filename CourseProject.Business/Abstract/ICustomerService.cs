using Core.Utilities.Result;
using CourseProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int id);
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
    }
}
