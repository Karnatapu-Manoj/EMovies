using System.ComponentModel.DataAnnotations;

namespace EMovies.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Profile Picture URL")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        public string? Bio { get; set; }


        //One-To-Many RelationShip between Producers and Movies
        //a Producer can have(perform) Multiple Movies but a Movie Can Have only One Producer.
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
