using Itech.Data.Infrastructure;
using Itech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Data.Repositories
{
    public interface IPromotionDetailRepository : IRepository<PromotionDetail>
    {

    }
    public class PromotionDetailRepository : RepositoryBase<PromotionDetail>, IPromotionDetailRepository
    {
        public PromotionDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
