using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IMemberRepository
    {

    }
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}