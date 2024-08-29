using Microsoft.EntityFrameworkCore;
using System;
using TCCMS.Domain.Entities;
using TCCMS.Domain.Interfaces;
using TCCMS.Domain.Specification;
using TCCMS.Infrastructure.Persistance;

namespace TCCMS.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appContext;

        public GenericRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _appContext.Set<T>().FirstAsync(x => x.Id == id);
        }

        public async Task<List<T>> ListAllAsync()
        {
            return await _appContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdWithSpecs(ISpecification<T> specs)
        {
            return await ApplySpecification(specs).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllWithSpecs(ISpecification<T> specs)
        {
            return await ApplySpecification(specs).ToListAsync();
        }


        private IQueryable<T> ApplySpecification(ISpecification<T> specs)
        {
            return SpecificationEvaulator<T>.GetQuery(_appContext.Set<T>(), specs);
        }



    }
}
