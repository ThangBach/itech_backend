using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IBrandRepository
    {
    }

    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}