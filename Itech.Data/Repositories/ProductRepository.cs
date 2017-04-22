using Itech.Data.Infrastructure;
using Itech.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Itech.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAllByName(string Name, int pageIndex, int pageSize, out int totalRow);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Product> GetAllByName(string Name, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Products
                        where p.Name == Name
                        select p;

            totalRow = query.Count();

            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;
        }
    }
}