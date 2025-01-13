using WebProgrammingDemoProject.ViewModels.Books;

namespace WebProgrammingDemoProject.Interfaces
{
    public interface IBooksService
    {
        Task CreateAsync(CreateBookInputModel createBookInputModel);
    }
}
