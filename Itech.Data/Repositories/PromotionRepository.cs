using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IPromotionRepository : IRepository<Promotion>
    {
    }

    public class PromotionRepository : RepositoryBase<Promotion>, IPromotionRepository
    {
        public PromotionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}