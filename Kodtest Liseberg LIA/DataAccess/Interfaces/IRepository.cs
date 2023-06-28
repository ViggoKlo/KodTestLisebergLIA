using DataAccess.Models;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);

        List<T> GetAll();

        void Update(T entity);

        void Delete(Guid id);

        T GetById(Guid id);
    }
}
