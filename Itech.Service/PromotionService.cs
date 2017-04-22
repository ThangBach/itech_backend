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
    public interface IPromotionService
    {
        void Add(Promotion promotion);
        void Update(Promotion promotion);
        void Delete(int promotionID);
        IEnumerable<Promotion> GetAll();
    }
    public class PromotionService:IPromotionService
    {
        IPromotionRepository _promotionRepository;
        IUnitOfWork _unitOfWork;

        public PromotionService(IPromotionRepository promotionRepository, IUnitOfWork unitOfWork)
        {
            this._promotionRepository = promotionRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Promotion promotion)
        {
            _promotionRepository.Add(promotion);
        }

        public void Delete(int promotionID)
        {
            _promotionRepository.Delete(promotionID);
        }

        public IEnumerable<Promotion> GetAll()
        {
            return _promotionRepository.GetAll();
        }

        public void Update(Promotion promotion)
        {
            _promotionRepository.Update(promotion);
        }
    }
}
