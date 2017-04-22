using System;
using System.Linq;
using System.Linq.Expressions;

namespace Itech.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // them
        void Add(T entity);

        // capnhat
        void Update(T entity);

        // xoa
        void Delete(T entity);

        void Delete(int entityID);

        // xoa nhieu
        void DeleteMulti(Expression<Func<T, bool>> where);

        // doi tuong theo id
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}