using Itech.Data.Infrastructure;
using Itech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Data.Repositories
{
    public interface IPriceRepository : IRepository<Price>
    {
    }
    public class PriceRepository : RepositoryBase<Price>, IPriceRepository
    {
        public PriceRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
