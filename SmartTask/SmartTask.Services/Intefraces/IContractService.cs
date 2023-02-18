using SmartTask.Models.Entities;
using SmartTask.Models.Requests;
using SmartTask.Models.Responses;

namespace SmartTask.Services.Intefraces
{
    public interface IContractService
    {
        Task<IEnumerable<PlacementContractResponse>> GetAllContractsAsync(CancellationToken cancellationToken);
        Task AddContractAsync(PlacementContractRequest contractRequest, CancellationToken cancellationToken);
    }
}
