using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Interfaces.ServicesInterfaces
{
    public interface IEnterpriseService
    {
        Task<IEnumerable<Enterprise>> GetEnterprises();
        Task<Enterprise> FindEnterpriseById(int enterpriseId);
        Task<bool> InsertEnterprise(Enterprise enterprise);
        Task<bool> UpdateEnterprise(Enterprise enterprise);
        Task<bool> DeleteEnterprise(int enterpriseId);
    }
}
