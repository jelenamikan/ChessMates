using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ChessMates.Models
{
    [Serializable]
    [XmlRoot("player")]
    public class ImportPlayersFromXML
    {
        [XmlElement("fideid")]
        public string fideid { get; set; }

        [XmlElement("name")]
        public string name { get; set; }

        [XmlElement("country")]
        public string country { get; set; }

        [XmlElement("sex")]
        public string sex { get; set; }

        [XmlElement("title")]
        public string title { get; set; }

        [XmlElement("w_title")]
        public string w_title { get; set; }

        [XmlElement("o_title")]
        public string o_title { get; set; }

        [XmlElement("foa_title")]
        public string foa_title { get; set; }

        [XmlElement("rating")]
        public Nullable<int> rating { get; set; }

        [XmlElement("games")]
        public Nullable<int> games { get; set; }

        [XmlElement("k")]
        public Nullable<int> k { get; set; }

        [XmlElement("rapid_rating")]
        public Nullable<int> rapid_rating { get; set; }

        [XmlElement("rapid_games")]
        public Nullable<int> rapid_games { get; set; }

        [XmlElement("rapid_k")]
        public Nullable<int> rapid_k { get; set; }

        [XmlElement("blitz_rating")]
        public Nullable<int> blitz_rating { get; set; }

        [XmlElement("blitz_games")]
        public Nullable<int> blitz_games { get; set; }

        [XmlElement("blitz_k")]
        public Nullable<int> blitz_k { get; set; }

        [XmlElement("birthday")]
        public Nullable<int> birthyear { get; set; }

        [XmlElement("flag")]
        public string flag { get; set; }

        [XmlElement("image")]
        public string image { get; set; }

    }

    [MetadataType(typeof(ImportPlayersFromXML))]
    public partial class Player
    {

    }
}