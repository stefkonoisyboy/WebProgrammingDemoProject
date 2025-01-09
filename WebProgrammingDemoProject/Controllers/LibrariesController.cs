using Microsoft.AspNetCore.Mvc;
using WebProgrammingDemoProject.Interfaces;
using WebProgrammingDemoProject.ViewModels.Libraries;

namespace WebProgrammingDemoProject.Controllers
{
    public class LibrariesController : Controller
    {
        private readonly ILibrariesService librariesService;

        public LibrariesController(ILibrariesService librariesService)
        {
            this.librariesService = librariesService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<LibraryViewModel> libraryViewModels = await this.librariesService
                .GetAllAsync();

            return this.View(libraryViewModels);
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLibraryInputModel createLibraryInputModel) 
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(createLibraryInputModel);
            }

            await this.librariesService.CreateAsync(createLibraryInputModel);
            this.TempData["Message"] = "Library is created successfully!";

            return this.RedirectToAction("All", "Libraries");
        }
    }
}
