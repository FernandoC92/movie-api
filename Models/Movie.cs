using System.ComponentModel.DataAnnotations;

namespace movieApi.Models
{
    public class Movie 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Synopsis { get; set; }
        public string ReleaseDate { get; set; }
        public string Classification { get; set; }
        public string Producer { get; set; }
        public string Duration { get; set; }
        public string Budget { get; set; }
        public string GateMoney { get; set; }
    }

}