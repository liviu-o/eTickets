using eTickets.Web.Data;
using eTickets.Web.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Cinema);
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetMovieByIDAsync(id);
            return View(data);
        }
    }
}
