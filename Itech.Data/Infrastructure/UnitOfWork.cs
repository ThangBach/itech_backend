namespace Itech.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ItechDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ItechDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}