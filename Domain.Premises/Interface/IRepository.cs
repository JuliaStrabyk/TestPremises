using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Premises.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        void Create(T item);
        void Update(T item);
        Task Delete(Guid id);
    }
}
