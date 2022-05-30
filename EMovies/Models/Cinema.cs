using System.ComponentModel.DataAnnotations;

namespace EMovies.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Banner Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Banner Name")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}