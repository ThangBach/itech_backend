using Itech.Data.Infrastructure;
using Itech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Data.Repositories
{
    public interface IPromotionDetailRepository
    {

    }
    public class PromotionDetailRepository : RepositoryBase<PromotionDetail>, IPromotionDetailRepository
    {
        public PromotionDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
