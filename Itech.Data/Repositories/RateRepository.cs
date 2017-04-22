﻿using Itech.Data.Infrastructure;
using Itech.Model.Models;

namespace Itech.Data.Repositories
{
    public interface IRateRepository
    {
    }

    public class RateRepository : RepositoryBase<Rate>, IRateRepository
    {
        public RateRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}