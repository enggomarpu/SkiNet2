

using Microsoft.EntityFrameworkCore;
using TCCMS.Domain.Entities;
using TCCMS.Domain.Specification;

namespace TCCMS.Infrastructure.Persistance
{
    public static class SpecificationEvaulator<TEntity> where TEntity : BaseEntity
    {

        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specs)
        {
            var query = inputQuery;

            if (specs != null) {
                query = query.Where(specs.Criteria);
            }

            query = specs.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;




        }


    }
}
