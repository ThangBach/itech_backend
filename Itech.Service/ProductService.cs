using Itech.Model.Models;
using System.Collections.Generic;
using System;
using Itech.Data.Repositories;
using Itech.Data.Infrastructure;

namespace Itech.Service
{
    public interface IProductService
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(int productID);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalRow);

        IEnumerable<Product> GetAllByName(string name, int pageIndex, int pageSize, out int totalRow);

        Product GetByID(int ProductID);

        void SaveChanges();
    }

    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(int productID)
        {
            _productRepository.Delete(productID);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll(new string[] { "ProductCategory"});
        }

        public IEnumerable<Product> GetAllByName(string name, int pageIndex, int pageSize, out int totalRow)
        {
            return _productRepository.GetAllByName(name, pageIndex, pageSize,out totalRow);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status == true, out totalRow, page, pagesize);
        }

        public Product GetByID(int productID)
        {
            return _productRepository.GetSingleById(productID);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}