using Core.Aspects.Autofac.Validation;
using Core.CrosscCuttingConcerns.Validation;
using Core.Utilities.Result;
using CourseProject.Business.Abstract;
using CourseProject.Business.ValidationRules.FluentValidation;
using CourseProject.DataAccess.Abstract;
using CourseProject.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Ekleme Başarılı");
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Silme  Başarılı");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Ürünler Getiirldi");
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId==id), "Ürün Getirildi");
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Güncelleme  Başarılı");
        }
    }
}
