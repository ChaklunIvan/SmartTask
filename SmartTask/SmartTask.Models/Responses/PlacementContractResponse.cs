namespace SmartTask.Models.Responses
{
    public class PlacementContractResponse
    {
        public int Id { get; set; }
        public string? PremisesName { get; set; }
        public string? EquipmentType { get; set; }
        public int EquipmentCount { get; set; }
    }
}
