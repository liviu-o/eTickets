using eTickets.Web.Data.Base;
using eTickets.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context){ }
    }
}
