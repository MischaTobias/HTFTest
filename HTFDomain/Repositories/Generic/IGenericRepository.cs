namespace HTFDomain.Repositories.Generic;

public interface IGenericRepository<T> where T : class
{
    Task<T> AddAsync(T newEntity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int Id);
    Task UpdateAsync(T entity);
}