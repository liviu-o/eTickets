using eTickets.Web.Data.Base;
using eTickets.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context){ }
    }
}
