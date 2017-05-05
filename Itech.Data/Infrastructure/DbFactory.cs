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


        // Khởi tạo Dbcontext
        public ItechDbContext init()
        {
            return dbContext ?? (dbContext = new ItechDbContext());
        }


        // giải phóng bộ nhớ khi không sử dụng
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
