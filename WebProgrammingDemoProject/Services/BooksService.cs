using WebProgrammingDemoProject.Data;
using WebProgrammingDemoProject.Data.Entities;
using WebProgrammingDemoProject.Interfaces;
using WebProgrammingDemoProject.ViewModels.Books;

namespace WebProgrammingDemoProject.Services
{
    public class BooksService : IBooksService
    {
        private readonly ApplicationDbContext dbContext;

        public BooksService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(CreateBookInputModel createBookInputModel)
        {
            Book book = new Book
            {
                Title = createBookInputModel.Title,
                ISBN = createBookInputModel.ISBN,
                GenreId = createBookInputModel.GenreId,
                PageCount = createBookInputModel.PageCount,
                PublishedYear = createBookInputModel.PublishedYear
            };

            await this.dbContext.Books.AddAsync(book);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
