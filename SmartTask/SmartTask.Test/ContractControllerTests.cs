using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using SmartTask.API.Controllers;
using SmartTask.Models.Requests;
using SmartTask.Models.Responses;
using SmartTask.Services.Intefraces;
using Xunit;

namespace SmartTask.Test
{
    public class ContractControllerTests
    {

        private readonly CancellationTokenSource cts = new();
        private readonly Mock<IContractService> _mock = new ();
        private readonly ContractsController _controller;

        public ContractControllerTests()
        {
            _controller = new ContractsController(_mock.Object);
        }

        [Fact]
        public async void GetContracts_ReturnsListOfContracts()
        {
            // Arrange
            _mock.Setup(serv => serv.GetAllContractsAsync(cts.Token).Result).Returns(GetTestContracts());

            // Act
            var result = await _controller.GetContractsAsync(cts.Token);

            // Assert
            var action = Assert.IsType<ActionResult<IEnumerable<PlacementContractResponse>>>(result);
            var actionResult = Assert.IsAssignableFrom<OkObjectResult>(action.Result);
            var model = Assert.IsAssignableFrom<IEnumerable<PlacementContractResponse>>(actionResult.Value);
            Assert.Equal(GetTestContracts().Count(), model.Count());
        }

        private static IEnumerable<PlacementContractResponse> GetTestContracts()
        {
            var contracts = new List<PlacementContractResponse>() 
            {
                new PlacementContractResponse { Id = 1, PremisesName = "Kitchen", EquipmentType = "Equipment for thermal processing of food products", EquipmentCount = 2},
                new PlacementContractResponse { Id = 2, PremisesName = "Shed", EquipmentType = "Computing Devices", EquipmentCount = 4},
                new PlacementContractResponse { Id = 3, PremisesName = "Warehouse", EquipmentType = "Industrial Furnaces", EquipmentCount = 2},
            };

            return contracts;
        }

        [Fact]
        public async void AddContract_Returns_StateAdded()
        {
            // Arrange
            var contract = new PlacementContractRequest() { PremisesName = "Shed", EquipmentType = "Computing Devices", EquipmentCount = 3};
            _mock.Setup(serv => serv.AddContractAsync(contract, cts.Token).Result).Returns(EntityState.Added);

            // Act
            var result = await _controller.AddContractAsync(contract, cts.Token);

            // Assert
            var action = Assert.IsType<ActionResult<EntityState>>(result);
            var actionResult = Assert.IsAssignableFrom<OkObjectResult>(action.Result);
            var state = Assert.IsAssignableFrom<EntityState>(actionResult.Value);
            Assert.Equal(EntityState.Added, state);
        }
    }
}