using System.Collections.Generic;

namespace business.Abstract
{
    public interface IService<T>
    where T : class
    {
        T GetById(int id);
        ICollection<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
        void Insert(T entity);
    }
}