using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartTask.DataBase;
using SmartTask.Models.Entities;
using SmartTask.Models.Exceptions;
using SmartTask.Models.Requests;
using SmartTask.Models.Responses;
using SmartTask.Services.Intefraces;

namespace SmartTask.Services
{
    public class ContractService : IContractService
    {
        private readonly SmartTaskDbContext _context;
        private readonly IMapper _mapper;

        public ContractService(SmartTaskDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlacementContractResponse>> GetAllContractsAsync(CancellationToken cancellationToken)
        {
            var contracts = await _context.Contracts.ToListAsync(cancellationToken);
            var contractsResponse = _mapper.Map<IEnumerable<PlacementContractResponse>>(contracts);

            return contractsResponse;
        }

        public async Task<EntityState> AddContractAsync(PlacementContractRequest contractRequest, CancellationToken cancellationToken)
        {
            var equipment = await _context.Equipments.FirstOrDefaultAsync(e => e.Name == contractRequest.EquipmentType, cancellationToken);
            var premises = await _context.Premises.FirstOrDefaultAsync(p => p.Name == contractRequest.PremisesName, cancellationToken);

            if (equipment == null || premises == null)
                throw new BadRequestDataException($"Equipment - {contractRequest.EquipmentType} or Premises - {contractRequest.PremisesName} does not exist!");

            var equipmentArea = equipment.Area * contractRequest.EquipmentCount;
            if (premises.StandartArea < equipmentArea)
                throw new BadRequestDataException($"Equipment area - {equipmentArea}. Will not fit in Placement standart area - {premises.StandartArea}.");

            var contract = new PlacementContract()
            {
                EquipmentType = equipment,
                Premises= premises,
                EquipmentCount = contractRequest.EquipmentCount
            };

            var changeTracking = await _context.Contracts.AddAsync(contract, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return changeTracking.State;
        }
    }
}