using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChessMates.Models
{

    public enum type
    {
        CLASSIC, BLITZ, RAPID
    }

    public class Tournament
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "City name is required")]
        public string City { get; set; }

        public type Type { get; set; }

        [Display(Name = "Federation")]
        public string isoAlpha3 { get; set; }
        public Country country { get; set; }

        public string StartString { get
            {
                return this.StartDate.ToShortDateString();
            }
        }

        public string EndString
        {
            get
            {
                return this.EndDate.ToShortDateString();
            }
        }
    }

}