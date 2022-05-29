using EMovies.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMovies.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public virtual ICollection<Actor>? Actors { get; set; }

        // Cinemas Section
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema? Cinema { get; set; }

        //Producers Section
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer? Producer { get; set; }
    }
}
