using Itech.Data.Infrastructure;
using Itech.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Itech.Data.Repositories
{
    public interface IProductCategoryRespository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRespository : RepositoryBase<ProductCategory>, IProductCategoryRespository
    {
        public ProductCategoryRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(x => x.Alias == alias);
        }
    }
}