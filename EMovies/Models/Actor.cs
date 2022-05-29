using System.ComponentModel.DataAnnotations;

namespace EMovies.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string? ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        //Many-To-Many RelationShip between Actor and Movies
        //an Actor can have(perform) Multiple Movies
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
