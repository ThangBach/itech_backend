using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using System;
using System.Collections.Generic;

namespace Itech.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory productCategory);

        void Update(ProductCategory productCategory);

        void Delete(int productCategoryID);

        IEnumerable<ProductCategory> GetAll();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        IProductCategoryRespository _productCategoryRespository;
        IUnitOfWork __unitOfWork;

        public ProductCategoryService(IProductCategoryRespository productCategoryRespository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRespository = productCategoryRespository;
            this.__unitOfWork = unitOfWork;
        }

        public void Add(ProductCategory productCategory)
        {
            _productCategoryRespository.Add(productCategory);
        }

        public void Delete(int productCategoryID)
        {
            _productCategoryRespository.Delete(productCategoryID);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRespository.GetAll(new string[] { "Products" });
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategoryRespository.Update(productCategory);
        }
    }
}