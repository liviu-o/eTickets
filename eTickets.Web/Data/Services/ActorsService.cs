using eTickets.Web.Data.Base;
using eTickets.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context){ }
    }
}
