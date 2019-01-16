using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChessMates.Models
{
    public class Continent
    {
        [Key]
        [Required(ErrorMessage = "Code is required")]
        public string continent { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string continentName { get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}