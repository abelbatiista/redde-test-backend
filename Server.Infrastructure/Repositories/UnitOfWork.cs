using Server.Core.Interfaces;
using Server.Core.Interfaces.EntitiesInterfaces;
using Server.Infrastructure.Data;
using Server.Infrastructure.Repositories.EntitiesRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly reddedatabaseContext _context;
        private readonly IEnterpriseRepository _enterpriseRepository;

        public UnitOfWork(reddedatabaseContext context)
        {
            _context = context;
        }

        public IEnterpriseRepository EnterpriseRepository => _enterpriseRepository ?? new EnterpriseRepository(_context);

        public async ValueTask DisposeAsync()
        {
            if (_context != null) await _context.DisposeAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
