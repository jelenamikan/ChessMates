using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChessMates.Models
{

    public enum sex
    {
        male, female
    }

    public enum title
    {
        GM, IM, FM, CM, WGM, WIM, WFM, WCM 
    }

    public class Player
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        public sex Sex { get; set; }

        public DateTime BirthDate { get; set; }

        public string Rating { get; set; }

        public title Title { get; set; }

    }
}