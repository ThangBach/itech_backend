using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Itech.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // them
        T Add(T entity);

        // capnhat
        void Update(T entity);

        // xoa
        T Delete(T entity);

        T Delete(int entityID);

        // xoa nhieu
        void DeleteMulti(Expression<Func<T, bool>> where);

        // doi tuong theo id
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IEnumerable<T> GetAll(string[] includes = null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}