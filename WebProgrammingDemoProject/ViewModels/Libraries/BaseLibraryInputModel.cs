using System.ComponentModel.DataAnnotations;

namespace WebProgrammingDemoProject.ViewModels.Libraries
{
    public class BaseLibraryInputModel
    {
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
    }
}
