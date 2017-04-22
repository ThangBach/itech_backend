using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IMemberCategoryRepository : IRepository<MemberCategory>
    {
    }

    public class MemberCategoryRepository : RepositoryBase<MemberCategory>, IMemberCategoryRepository
    {
        public MemberCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}