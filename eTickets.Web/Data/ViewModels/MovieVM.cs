using eTickets.Web.Data.Base;
using eTickets.Web.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Web.Models
{
    public class MovieVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<int> ActorIds { get; set; }
        public int CinemaId { get; set; }
        public int ProducerId { get; set; }
    }
 }

