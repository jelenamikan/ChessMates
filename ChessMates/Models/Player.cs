using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChessMates.Models
{

    public partial class Player
    {
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public string fideid { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        public string country { get; set; }

        [ForeignKey("country")]
        public Country federation { get; set; }

        public string sex { get; set; }

        public string title { get; set; }

        public string w_title { get; set; }

        public string o_title { get; set; }

        public string foa_title { get; set; }

        public Nullable<int> rating { get; set; }

        public Nullable<int> games { get; set; }

        public Nullable<int> k { get; set; }

        public Nullable<int> rapid_rating { get; set; }

        public Nullable<int> rapid_games { get; set; }

        public Nullable<int> rapid_k { get; set; }

        public Nullable<int> blitz_rating { get; set; }

        public Nullable<int> blitz_games { get; set; }

        public Nullable<int> blitz_k { get; set; }

        public Nullable<int> birthyear { get; set; }

        public string flag { get; set; }

        public string image { get; set; }

    }

}