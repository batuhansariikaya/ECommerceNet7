using ECommerceNet7.Application.Repositories;
using ECommerceNet7.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceNet7.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        public DbSet<T> Table => throw new NotImplementedException();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            throw new NotImplementedException();
        }
    }
}
