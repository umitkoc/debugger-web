using System.Collections.Generic;

namespace data.Abstract
{
    public interface IRepo<T>
    where T:class
    {
        T GetById(int id);
        ICollection<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
        void Insert(T entity);

         
    }
}