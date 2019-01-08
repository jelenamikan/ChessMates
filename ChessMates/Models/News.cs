using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChessMates.Models
{
    public class News
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Body { get; set; }
    }
}