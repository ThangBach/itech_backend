using System;

namespace Itech.Data.Infrastructure
{
    public interface IDbFactory: IDisposable
    {
        // khoi tao DBContext
        ItechDbContext init();
    }
}