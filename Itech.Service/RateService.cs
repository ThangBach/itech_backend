using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using System;
using System.Collections.Generic;

namespace Itech.Service
{
    public interface IRateService
    {
        void Add(Rate rate);

        void Update(Rate rate);

        void Delete(int rateID);

        IEnumerable<Rate> GetAll();
    }

    public class RateService : IRateService
    {
        private IRateRepository _rateRepository;
        private IUnitOfWork _unitOfWork;

        public RateService(IRateRepository rateRepository, IUnitOfWork unitOfWork)
        {
            this._rateRepository = rateRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Rate rate)
        {
            _rateRepository.Add(rate);
        }

        public void Delete(int rateID)
        {
            _rateRepository.Delete(rateID);
        }

        public IEnumerable<Rate> GetAll()
        {
            return _rateRepository.GetAll();
        }

        public void Update(Rate rate)
        {
            _rateRepository.Update(rate);
        }
    }
}