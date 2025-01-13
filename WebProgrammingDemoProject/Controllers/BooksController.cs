using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebProgrammingDemoProject.Interfaces;
using WebProgrammingDemoProject.ViewModels.Books;

namespace WebProgrammingDemoProject.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService booksService;
        private readonly IGenresService genresService;

        public BooksController(
            IBooksService booksService,
            IGenresService genresService)
        {
            this.booksService = booksService;
            this.genresService = genresService;
        }

        public async Task<IActionResult> Create()
        {
            IEnumerable<SelectListItem> genreItems = await this.genresService.GetAllForSelectAsync();

            CreateBookInputModel createBookInputModel = new CreateBookInputModel
            {
                GenreItems = genreItems,
            };

            return this.View(createBookInputModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookInputModel createBookInputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(createBookInputModel);
            }

            await this.booksService.CreateAsync(createBookInputModel);

            return this.RedirectToAction("Index", "Home");
        }
    }
}
