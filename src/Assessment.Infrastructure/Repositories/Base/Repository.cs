using Assessment.Core.Repositories.Base;
using Assessment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AssessmentDbContext _assessmentDbContext;

        public Repository(AssessmentDbContext assessmentDbContext)
        {
            _assessmentDbContext = assessmentDbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _assessmentDbContext.Set<T>().AddAsync(entity);
            await _assessmentDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _assessmentDbContext.Set<T>().Remove(entity);
            await _assessmentDbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _assessmentDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _assessmentDbContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
