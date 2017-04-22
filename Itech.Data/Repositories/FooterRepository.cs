using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IFooterRepository
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}