namespace SmartTask.Models.Entities
{
    public class PlacementContract
    {
        public int Id { get; set; }
        public virtual int PremisesId { get; set; }
        public virtual ProductionPremises? Premises { get; set; }
        public virtual int EquipmentTypeId { get; set; }
        public virtual EquipmentType? EquipmentType { get; set; }
        public int EquipmentCount { get; set; }
    }
}
