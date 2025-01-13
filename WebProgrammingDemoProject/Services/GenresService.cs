using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProgrammingDemoProject.Data;
using WebProgrammingDemoProject.Interfaces;

namespace WebProgrammingDemoProject.Services
{
    public class GenresService : IGenresService
    {
        private readonly ApplicationDbContext dbContext;

        public GenresService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectListItem>> GetAllForSelectAsync()
        {
            IEnumerable<SelectListItem> genres = await this.dbContext.Genres
                .Select(g => new SelectListItem
                {
                    Value = g.Id.ToString(),
                    Text = g.Name
                })
                .ToListAsync();

            return genres;
        }
    }
}
