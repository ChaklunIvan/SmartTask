using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartTask.Models.Entities;
using SmartTask.Models.Requests;
using SmartTask.Models.Responses;
using SmartTask.Services.Intefraces;

namespace SmartTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService _contractService;

        public ContractsController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlacementContractResponse>>> GetContractsAsync(CancellationToken cancellationToken)
        {
            var contracts = await _contractService.GetAllContractsAsync(cancellationToken);

            return Ok(contracts);
        }

        [HttpPost]
        public async Task<ActionResult> AddContractAsync([FromBody] PlacementContractRequest contract, CancellationToken cancellationToken)
        {
            await _contractService.AddContractAsync(contract, cancellationToken);

            return Ok();
        }
    }
}
