using System;
using System.ComponentModel.DataAnnotations;

namespace MusicMVC.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Singer { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
        public string Audio { get; set; }
    }
}