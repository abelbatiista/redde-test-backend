using Microsoft.EntityFrameworkCore;
using Server.Core.Entities;
using Server.Core.Interfaces;
using Server.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly reddedatabaseContext _context;
        protected readonly DbSet<T> _entities;

        public Repository(reddedatabaseContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task Delete(int id)
        {
            T entity = await _entities.FirstOrDefaultAsync(x => x.Id == id);
            _entities.Remove(entity);
        }

        public async Task<T> FindById(int id)
        {
            return await _entities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task Insert(T item)
        {
            await _entities.AddAsync(item);
        }

        public async Task Update(T item)
        {
            T entity = await _entities.FirstOrDefaultAsync(x => x.Id == item.Id);
            _context.Entry(entity).CurrentValues.SetValues(item);
        }
    }
}
