using WebProgrammingDemoProject.ViewModels.Libraries;

namespace WebProgrammingDemoProject.Interfaces
{
    public interface ILibrariesService
    {
        Task CreateAsync(CreateLibraryInputModel createLibraryInputModel);

        Task<IEnumerable<LibraryViewModel>> GetAllAsync();
    }
}
