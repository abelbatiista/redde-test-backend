using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Core.Entities;
using Server.Core.Interfaces.ServicesInterfaces;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnterprisesController : ControllerBase
    {
        private readonly IEnterpriseService _enterpriseService;

        public EnterprisesController(IEnterpriseService enterpriseService)
        {
            _enterpriseService = enterpriseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _enterpriseService.GetEnterprises();
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> FindById(int Id)
        {
            var response = await _enterpriseService.FindEnterpriseById(Id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Enterprise enterprise)
        {
            var response = await _enterpriseService.InsertEnterprise(enterprise);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Enterprise enterprise)
        {
            var response = await _enterpriseService.UpdateEnterprise(enterprise);
            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var response = await _enterpriseService.DeleteEnterprise(Id);
            return Ok(response);
        }

    }
}
