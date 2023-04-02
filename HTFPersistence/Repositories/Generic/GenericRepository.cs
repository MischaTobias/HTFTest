using HTFDomain.Repositories.Generic;
using HTFPersistence.Context;
using Microsoft.EntityFrameworkCore;

namespace HTFPersistence.Repositories.Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly HTFContext _context;
    public GenericRepository(HTFContext context)
    {
        _context = context;
    }

    public async Task<T> AddAsync(T newEntity)
    {
        await _context.AddAsync(newEntity);
        await _context.SaveChangesAsync();

        return newEntity;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int Id)
    {
        return await _context.Set<T>().FindAsync(Id);
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}