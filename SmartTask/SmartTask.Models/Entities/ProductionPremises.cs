namespace SmartTask.Models.Entities
{
    public class ProductionPremises
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double StandartArea { get; set; }
        public virtual IEnumerable<PlacementContract>? Contracts { get; set; }
    }
}
