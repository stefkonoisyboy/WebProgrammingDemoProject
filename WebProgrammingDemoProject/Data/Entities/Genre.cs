using System.ComponentModel.DataAnnotations;

namespace WebProgrammingDemoProject.Data.Entities
{
    public class Genre
    {
        public Genre()
        {
            this.Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public bool IsFiction { get; set; }

        [Required]
        public int Popularity { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
