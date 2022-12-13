using eTickets.Web.Data.Base;
using eTickets.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context){ }
    }
}
