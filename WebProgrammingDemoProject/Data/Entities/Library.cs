using System.ComponentModel.DataAnnotations;

namespace WebProgrammingDemoProject.Data.Entities
{
    public class Library
    {
        public Library()
        {
            this.Books = new HashSet<BookLibrary>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        public int EstablishedYear { get; set; }

        public ICollection<BookLibrary> Books { get; set; }
    }
}
