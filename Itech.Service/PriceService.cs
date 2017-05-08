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
    public interface IPriceService
    {
        void Add(Price price);
        void Update(Price price);
        void Delete(int priceID);
        IEnumerable<Price> GetAll();
    }
    public class PriceService : IPriceService
    {
        IPriceRepository _priceRepository;
        IUnitOfWork _unitOfWork;

        public PriceService(IPriceRepository priceRepository, IUnitOfWork unitOfWork)
        {
            this._priceRepository = priceRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Price price)
        {
            _priceRepository.Add(price);
        }

        public void Delete(int priceID)
        {
            _priceRepository.Delete(priceID);
        }

        public IEnumerable<Price> GetAll()
        {
            return _priceRepository.GetAll();
        }

        public void Update(Price price)
        {
            _priceRepository.Update(price);
        }
    }
}
