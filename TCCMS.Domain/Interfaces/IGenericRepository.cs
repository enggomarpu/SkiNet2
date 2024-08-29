using TCCMS.Domain.Entities;
using TCCMS.Domain.Specification;

namespace TCCMS.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> ListAllAsync();
        Task<T> GetByIdAsync(int id);

        Task<T> GetByIdWithSpecs(ISpecification<T> specs);

        Task<IReadOnlyList<T>> ListAllWithSpecs(ISpecification<T> specs);

    }
}
