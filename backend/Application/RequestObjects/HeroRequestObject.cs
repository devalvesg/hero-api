using System.ComponentModel.DataAnnotations;

namespace Application.RequestObjects
{
    public class HeroRequestObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required"), MaxLength(120)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Hero name is required"), MaxLength(120)]
        public string HeroName { get; set; }
        public DateTime? Birthday { get; set; }
        [Required(ErrorMessage = "Height is required")]
        [Range(0.01, 9.99, ErrorMessage = "Height must be greater than zero.")]
        public decimal? Height { get; set; }
        [Required(ErrorMessage = "Weight is required")]
        [Range(0.01, 9999.99, ErrorMessage = "Weight must be greater than zero.")]
        public decimal? Weight { get; set; }
        public virtual List<int> SuperPowerIds { get; set; }
    }
}
