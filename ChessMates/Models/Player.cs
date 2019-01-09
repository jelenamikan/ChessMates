using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChessMates.Models
{

    public enum sex
    {
        M, F
    }

    public enum title
    {
        GM, IM, FM, CM, WGM, WIM, WFM, WCM 
    }

    public class Player
    {
        [Column(Order = 0)]
        public long Id { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Column(Order = 2)]
        public string Fed { get; set; }

        [Column(Order = 3)]
        public sex Sex { get; set; }

        [Column(Order = 4)]
        public title Title { get; set; }

        [Column(Order = 5)]
        public string Wtit { get; set; }

        [Column(Order = 6)]
        public string Otit { get; set; }

        [Column(Order = 7)]
        public string Foa { get; set; }

        [Column(Order = 8)]
        public int ClRating { get; set; }

        [Column(Order = 9)]
        public int ClGames { get; set; }

        [Column(Order = 10)]
        public int CK { get; set; }

        [Column(Order = 11)]
        public int RaRating { get; set; }

        [Column(Order = 12)]
        public int RaGames { get; set; }

        [Column(Order = 13)]
        public int RK { get; set; }

        [Column(Order = 14)]
        public int BlRating { get; set; }

        [Column(Order = 15)]
        public int BlGames { get; set; }

        [Column(Order = 16)]
        public int BK { get; set; }

        [Column(Order = 17)]
        public int BirthYear { get; set; }

        [Column(Order = 18)]
        public string Flag { get; set; }

    }
}