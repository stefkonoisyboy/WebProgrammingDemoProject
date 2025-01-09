using System.ComponentModel.DataAnnotations;

namespace WebProgrammingDemoProject.ViewModels.Libraries
{
    public class LibraryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public int EstablishedYear { get; set; }
    }
}
