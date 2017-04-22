using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Service
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int brandID);
        IEnumerable<Brand> GetAll();
    }
    public class BrandService : IBrandService
    {
        IBrandRepository _brandRepository;
        IUnitOfWork _unitOfWork;

        public BrandService(IBrandRepository brandRepository, IUnitOfWork unitOfWork)
        {
            this._brandRepository = brandRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Brand brand)
        {
            _brandRepository.Add(brand);
        }

        public void Delete(int brandID)
        {
            _brandRepository.Delete(brandID);
        }

        public IEnumerable<Brand> GetAll()
        {
            return _brandRepository.GetAll(new string[] { "Products" });
        }

        public void Update(Brand brand)
        {
            _brandRepository.Update(brand);
        }
    }
}
