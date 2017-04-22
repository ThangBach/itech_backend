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
    public interface IPromotionDetailService
    {
        void Add(PromotionDetail promotionDetail);
        void Update(PromotionDetail promotionDetail);
        void Delete(int promotionDetailID);
        IEnumerable<PromotionDetail> GetAll();
    }
    public class PromotionDetailService: IPromotionDetailService
    {
        IPromotionDetailRepository _promotionDetailRepository;
        IUnitOfWork _unitOfWork;

        public PromotionDetailService(IPromotionDetailRepository promotionDetailRepository, IUnitOfWork unitOfWork)
        {
            this._promotionDetailRepository = promotionDetailRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PromotionDetail promotionDetail)
        {
            _promotionDetailRepository.Add(promotionDetail);
        }

        public void Delete(int promotionDetailID)
        {
            _promotionDetailRepository.Delete(promotionDetailID);
        }

        public IEnumerable<PromotionDetail> GetAll()
        {
            return _promotionDetailRepository.GetAll();
        }

        public void Update(PromotionDetail promotionDetail)
        {
            _promotionDetailRepository.Update(promotionDetail);
        }
    }
}
