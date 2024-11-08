using CoffeeShop.Core.Models;
using CoffeeShop.Database.Context;
using CoffeeShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Database.Repositories
{
    public class CoffeeRepository : IRepository<Coffee>
    {
        private readonly CoffeeAppDbContext _context;

        public CoffeeRepository(CoffeeAppDbContext context)
        {
            _context = context;
        }

        public async Task<Coffee> GetByIdAsync(Guid id) =>
            await _context.Coffees.FindAsync(id);

        public async Task<IEnumerable<Coffee>> GetAllAsync() =>
            await _context.Coffees.ToListAsync();

        public async Task AddAsync(Coffee entity)
        {
            await _context.Coffees.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Coffee entity)
        {
            _context.Coffees.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var coffee = await _context.Coffees.FindAsync(id);
            if (coffee != null)
            {
                _context.Coffees.Remove(coffee);
                await _context.SaveChangesAsync();
            }
        }
    }
}