using System.ComponentModel.DataAnnotations;

namespace WebProgrammingDemoProject.Data.Entities
{
    public class Book
    {
        public Book()
        {
            this.Libraries = new HashSet<BookLibrary>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        [Range(1870, 2025)]
        public int PublishedYear { get; set; }

        [Required]
        [Range(1, 1500)]
        public int PageCount { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public ICollection<BookLibrary> Libraries { get; set; }
    }
}
