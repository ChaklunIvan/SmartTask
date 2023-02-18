namespace SmartTask.Models.Requests
{
    public class PlacementContractRequest
    {
        public string? PremisesName { get; set; }
        public string? EquipmentType { get; set; }
        public int EquipmentCount { get; set; }
    }
}
