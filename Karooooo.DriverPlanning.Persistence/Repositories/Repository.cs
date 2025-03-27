using Karooooo.DriverPlanning.Domain.Entities;
using Karooooo.DriverPlanning.Domain.Repositories;
using Karooooo.DriverPlanning.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.Repositories;

public class Repository<T> : IRepository<T> where T : class, IEntity
{
    protected readonly DbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
        var existingEntity = await _context.Set<T>().FindAsync(entity.Id);

        if (existingEntity is null)
        {
            throw new InvalidOperationException($"Entity with id {entity.Id} not found.");
        }

        _dbSet.Update(existingEntity);
        await _context.SaveChangesAsync();
    }
}
