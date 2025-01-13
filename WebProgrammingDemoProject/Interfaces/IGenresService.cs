using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebProgrammingDemoProject.Interfaces
{
    public interface IGenresService
    {
        Task<IEnumerable<SelectListItem>> GetAllForSelectAsync();
    }
}
