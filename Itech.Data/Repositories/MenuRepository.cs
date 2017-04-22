using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IMenuRepository
    {

    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}