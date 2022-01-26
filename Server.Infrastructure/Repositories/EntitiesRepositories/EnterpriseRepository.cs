using Server.Core.Entities;
using Server.Core.Interfaces.EntitiesInterfaces;
using Server.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastructure.Repositories.EntitiesRepositories
{
    public class EnterpriseRepository : Repository<Enterprise>, IEnterpriseRepository
    {
        public EnterpriseRepository(reddedatabaseContext context) : base(context) { }
    }
}
