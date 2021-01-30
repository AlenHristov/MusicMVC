using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MusicMVC.Models
{
    public class MusicGenreViewModel
    {
        public List<Song> Songs { get; set; }
        public SelectList Genres { get; set; }
        public string MusicGenre { get; set; }
        public string Song { get; set; }
        public string Singer { get; set; }
    }
}