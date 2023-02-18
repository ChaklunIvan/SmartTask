using AutoMapper;
using SmartTask.Models.Entities;
using SmartTask.Models.Requests;
using SmartTask.Models.Responses;

namespace SmartTask.API.Mapper
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<PlacementContract, PlacementContractResponse>()
                .ForMember(m => m.PremisesName, opt => opt.MapFrom(e => e.Premises.Name))
                .ForMember(m => m.EquipmentType, opt => opt.MapFrom(e => e.EquipmentType.Name));

        }
    }
}
