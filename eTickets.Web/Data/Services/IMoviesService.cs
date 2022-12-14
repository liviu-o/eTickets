using eTickets.Web.Data.Base;
using eTickets.Web.Data.ViewModels;
using eTickets.Web.Models;

namespace eTickets.Web.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIDAsync(int id);
        Task<MovieDropdownsVm> GetNewMovieDropdownsValues();
    }
}
