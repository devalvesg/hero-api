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
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
    }
}
