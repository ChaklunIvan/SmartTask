using Microsoft.EntityFrameworkCore;
using SmartTask.DataBase;
using SmartTask.Models.Entities;
using SmartTask.Services.Intefraces;

namespace SmartTask.Services
{
    public class ContractService : IContractService
    {
        private readonly SmartTaskDbContext _context;

        public ContractService(SmartTaskDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PlacementContract>> GetAllContractsAsync(CancellationToken cancellationToken)
        {
            var contracts = await _context.Contracts.ToListAsync(cancellationToken);
            return contracts;
        }

        public async Task AddContractAsync(PlacementContract contract)
        {
            await _context.Contracts.AddAsync(contract);
            await _context.SaveChangesAsync();
        }
    }
}