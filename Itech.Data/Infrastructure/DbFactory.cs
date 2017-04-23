using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ItechDbContext dbContext;

        public ItechDbContext init()
        {
            return dbContext ?? (dbContext = new ItechDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
