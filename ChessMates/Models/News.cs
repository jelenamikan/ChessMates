using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ChessMates.Models
{
    public class News
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(15000)]
        [AllowHtml]
        public string Body { get; set; }

        [MaxLength(1000)]
        [AllowHtml]
        public string Description { get; set; }

    }
}