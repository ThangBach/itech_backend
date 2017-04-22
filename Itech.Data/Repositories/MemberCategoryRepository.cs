using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IMemberCategoryRepository
    {
    }

    public class MemberCategoryRepository : RepositoryBase<MemberCategory>, IMemberCategoryRepository
    {
        public MemberCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}