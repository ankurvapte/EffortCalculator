using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EffortCalculator;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Category Name")]
    [MaxLength(30)]
    public required string Name { get; set; }

    [DisplayName("Display Order")]
    [Range(1, 100)]
    public int DisplayOrder { get; set; }
}
