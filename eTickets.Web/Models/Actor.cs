using eTickets.Web.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public  string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}
