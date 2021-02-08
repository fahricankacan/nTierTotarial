using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IEntityRepositorycs<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAllByCategory(int entity);
    }
}
