using Server.Core.Interfaces.EntitiesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Interfaces
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IEnterpriseRepository EnterpriseRepository { get; }
        Task SaveChangesAsync();
    }
}
