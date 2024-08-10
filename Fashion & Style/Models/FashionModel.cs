using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fashion___Style.Models
{
    public class FashionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public required string ClothName { get; set; }
        public required string Picture { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
    }
}
