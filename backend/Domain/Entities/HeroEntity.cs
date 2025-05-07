namespace Domain.Entities
{
    public class HeroEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Name { get; set; }
        public string HeroName { get; set; }
        public DateTime? Birthday { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public virtual List<HeroSuperPowerEntity> HeroSuperPowers { get; set; }
    }
}
