namespace SmartTask.Models.Entities
{
    public class EquipmentType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Area { get; set; }
        public virtual IEnumerable<PlacementContract>? Contracts { get; set; }
    }
}
