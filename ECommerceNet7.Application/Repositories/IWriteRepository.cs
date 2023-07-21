using ECommerceNet7.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceNet7.Application.Repositories
{
    public interface IWriteRepository<T> :IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        bool Remove(T entity);
        Task<bool> RemoveAsync(int id);
        bool Update(T model);
        Task<int> SaveAsync();
    }
}
