using Server.Core.Entities;
using Server.Core.Interfaces;
using Server.Core.Interfaces.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Services
{
    public class EnterpriseService : IEnterpriseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EnterpriseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteEnterprise(int enterpriseId)
        {
            try
            {
                await _unitOfWork.EnterpriseRepository.Delete(enterpriseId);
                await _unitOfWork.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Enterprise> FindEnterpriseById(int enterpriseId)
        {
            try
            {
                var response = await _unitOfWork.EnterpriseRepository.FindById(enterpriseId);
                return response ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Enterprise>> GetEnterprises()
        {
            try
            {
                var response = await _unitOfWork.EnterpriseRepository.GetAll();
                return response ?? null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> InsertEnterprise(Enterprise enterprise)
        {
            try
            {
                await _unitOfWork.EnterpriseRepository.Insert(enterprise);
                await _unitOfWork.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateEnterprise(Enterprise enterprise)
        {
            try
            {
                await _unitOfWork.EnterpriseRepository.Update(enterprise);
                await _unitOfWork.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
