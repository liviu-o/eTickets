using eTickets.Web.Controllers;
using eTickets.Web.Models;

namespace eTickets.Web.Data.ViewModels
{
    public class MovieDropdownsVm
    {
        public MovieDropdownsVm()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }

        public List<Producer> Producers { get; set;}
        public List<Cinema> Cinemas { get; set;}
        public List<Actor> Actors { get; set;}
    }
}
