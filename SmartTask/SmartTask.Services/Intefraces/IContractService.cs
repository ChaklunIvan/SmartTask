using SmartTask.Models.Entities;

namespace SmartTask.Services.Intefraces
{
    public interface IContractService
    {
        Task<IEnumerable<PlacementContract>> GetAllContractsAsync(CancellationToken cancellationToken);
        Task AddContractAsync(PlacementContract contract);
    }
}
