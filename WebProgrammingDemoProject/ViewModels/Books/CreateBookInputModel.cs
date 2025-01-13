using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WebProgrammingDemoProject.ViewModels.Books
{
    public class CreateBookInputModel
    {
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

        public IEnumerable<SelectListItem> GenreItems { get; set; }
    }
}
