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
    public interface IDiscountService
    {
        void Add(Discount discount);
        void Update(Discount discount);
        void Delete(int discountID);
        IEnumerable<Discount> GetAll();
    }
    public class DiscountService : IDiscountService
    {

        IDiscountRepository _discountRepositoryy;
        IUnitOfWork _unitOfWork;

        public DiscountService(IDiscountRepository discountRepositoryy, IUnitOfWork unitOfWork)
        {
            this._discountRepositoryy = discountRepositoryy;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Discount discount)
        {
            _discountRepositoryy.Add(discount);
        }

        public void Delete(int discountID)
        {
            _discountRepositoryy.Delete(discountID);
        }

        public IEnumerable<Discount> GetAll()
        {
            return _discountRepositoryy.GetAll();
        }

        public void Update(Discount discount)
        {
             _discountRepositoryy.Update(discount);
        }
    }
}
