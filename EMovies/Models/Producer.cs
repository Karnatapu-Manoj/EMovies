using EMovies.Data.BaseRepo;
using System.ComponentModel.DataAnnotations;

namespace EMovies.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Producer")]
        [Required(ErrorMessage = "Producer Profile Picture is required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Producer Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Producer Name should be between 3 to 50 Chars")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Producer Biography is required")]
        public string? Bio { get; set; }


        //One-To-Many RelationShip between Producers and Movies
        //a Producer can have(perform) Multiple Movies but a Movie Can Have only One Producer.
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
