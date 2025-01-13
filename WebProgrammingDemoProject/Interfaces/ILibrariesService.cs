using WebProgrammingDemoProject.ViewModels.Libraries;

namespace WebProgrammingDemoProject.Interfaces
{
    public interface ILibrariesService
    {
        Task CreateAsync(CreateLibraryInputModel createLibraryInputModel);

        Task EditAsync(EditLibraryInputModel editLibraryInputModel);

        Task DeleteAsync(int id);

        Task<EditLibraryInputModel> GetByIdAsync(int id);

        Task<IEnumerable<LibraryViewModel>> GetAllAsync();
    }
}
