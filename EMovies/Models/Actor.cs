using EMovies.Data.BaseRepo;
using System.ComponentModel.DataAnnotations;

namespace EMovies.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Actor")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string? ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Actor Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Actor Name must be between 3 and 50 chars")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Actor Biography is Required")]
        public string? Bio { get; set; }

        //Many-To-Many RelationShip between Actor and Movies
        //an Actor can have(perform) Multiple Movies
        //public virtual ICollection<Movie>? Movies { get; set; }

        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
