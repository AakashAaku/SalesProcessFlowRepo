using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces.BaseInterface
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(int id);
        T SaveChanges(T entity);
        void Update(T entity);
    }
}
