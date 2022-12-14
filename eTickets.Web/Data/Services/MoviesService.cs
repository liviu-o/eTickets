using eTickets.Web.Data.Base;
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
    }
}
