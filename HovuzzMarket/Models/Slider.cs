using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EdgeCut.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(100), Required(ErrorMessage =" Title teleb olunur")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
