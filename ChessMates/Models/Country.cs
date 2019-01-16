using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChessMates.Models
{
    public class Country
    {
        [Key]
        [Required(ErrorMessage = "Code is required")]
        public string isoAlpha3 { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string countryName { get; set; }

        public string continent { get; set; }
        public Continent Cont { get; set; }

        public ICollection<Player> Players { get; set; }
        public ICollection<Tournament> Tournaments { get; set; }
    }
}