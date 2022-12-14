using eTickets.Web.Data.Base;
using eTickets.Web.Models;

namespace eTickets.Web.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIDAsync(int id);
    }
}
