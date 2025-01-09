using Microsoft.EntityFrameworkCore;
using WebProgrammingDemoProject.Data;
using WebProgrammingDemoProject.Data.Entities;
using WebProgrammingDemoProject.Interfaces;
using WebProgrammingDemoProject.ViewModels.Libraries;

namespace WebProgrammingDemoProject.Services
{
    public class LibrariesService : ILibrariesService
    {
        private readonly ApplicationDbContext dbContext;

        public LibrariesService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(CreateLibraryInputModel createLibraryInputModel)
        {
            Library library = new Library
            {
                Name = createLibraryInputModel.Name,
                Address = createLibraryInputModel.Address,
                City = createLibraryInputModel.City,
                EstablishedYear = createLibraryInputModel.EstablishedYear,
            };

            await this.dbContext.Libraries.AddAsync(library);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<LibraryViewModel>> GetAllAsync()
        {
            IEnumerable<LibraryViewModel> libraryViewModels = await this.dbContext.Libraries
                .Select(l => new LibraryViewModel 
                {
                    Id = l.Id,
                    Name = l.Name,
                    Address = l.Address,
                    City = l.City,
                    EstablishedYear = l.EstablishedYear,
                })
                .ToListAsync();

            return libraryViewModels;
        }
    }
}
