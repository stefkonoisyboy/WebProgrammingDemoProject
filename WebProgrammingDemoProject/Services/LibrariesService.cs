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

        public async Task DeleteAsync(int id)
        {
            Library library = await this.dbContext.Libraries
                .FirstOrDefaultAsync(l => l.Id == id);

            this.dbContext.Libraries.Remove(library);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(EditLibraryInputModel editLibraryInputModel)
        {
            Library library = await this.dbContext.Libraries
                .FirstOrDefaultAsync(l => l.Id == editLibraryInputModel.Id);

            library.Name = editLibraryInputModel.Name;
            library.Address = editLibraryInputModel.Address;
            library.City = editLibraryInputModel.City;
            library.EstablishedYear = editLibraryInputModel.EstablishedYear;

            this.dbContext.Libraries.Update(library);

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

        public async Task<EditLibraryInputModel> GetByIdAsync(int id)
        {
            EditLibraryInputModel editLibraryInputModel = await this.dbContext.Libraries
                .Where(l => l.Id == id)
                .Select(l => new EditLibraryInputModel
                {
                    Id = l.Id,
                    Name = l.Name,
                    Address = l.Address,
                    City = l.City,
                    EstablishedYear = l.EstablishedYear,
                })
                .FirstOrDefaultAsync();

            return editLibraryInputModel;
        }
    }
}
