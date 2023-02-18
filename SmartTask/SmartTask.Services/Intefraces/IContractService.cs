using Microsoft.EntityFrameworkCore;
using SmartTask.Models.Entities;
using SmartTask.Models.Requests;
using SmartTask.Models.Responses;

namespace SmartTask.Services.Intefraces
{
    public interface IContractService
    {
        Task<IEnumerable<PlacementContractResponse>> GetAllContractsAsync(CancellationToken cancellationToken);
        Task<EntityState> AddContractAsync(PlacementContractRequest contractRequest, CancellationToken cancellationToken);
    }
}
