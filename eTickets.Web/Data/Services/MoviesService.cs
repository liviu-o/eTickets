using eTickets.Web.Data.Base;
using eTickets.Web.Data.ViewModels;
using eTickets.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context){
           _context = context;     
        }

        public async Task<Movie> GetMovieByIDAsync(int id)
        {
            var movieDetails = _context.Movies
                .Include(p => p.Cinema)
                .Include(c => c.Producer)
                .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefault(n => n.Id == id);
            return movieDetails;
        }

        public async Task<MovieDropdownsVm> GetNewMovieDropdownsValues()
        {
            var response = new MovieDropdownsVm()
            {
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };
       
            return response;
        }
    }
}
