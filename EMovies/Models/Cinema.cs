using EMovies.Data.BaseRepo;
using System.ComponentModel.DataAnnotations;

namespace EMovies.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Banner Logo")]
        [Required(ErrorMessage = "Banner Logo is required")]
        public string? Logo { get; set; }

        [Display(Name = "Banner Name")]
        [Required(ErrorMessage = "Banner Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Banner Name should be between 3 and 50 chars")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Banner Description is required")]
        public string? Description { get; set; }
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}