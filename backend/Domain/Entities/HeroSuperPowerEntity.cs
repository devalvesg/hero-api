using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class HeroSuperPowerEntity
    {

        public int Id { get; set; }
        public bool Deleted { get; set; }
        [ForeignKey("Hero")]
        public int HeroId { get; set; }
        public virtual HeroEntity Hero { get; set; }
        [ForeignKey("SuperPower")]
        public int SuperPowerId { get; set; }
        public virtual SuperPowerEntity SuperPower { get; set; }
    }
}
