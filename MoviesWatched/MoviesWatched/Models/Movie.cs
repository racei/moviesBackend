using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWatched.Models
{
    [JsonObject(Title="Movie")]
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Movie Title")]
        public string Title { get; set; }
        [Display(Name = "Year")]
        public int YearReleased { get; set; }
        [Display(Name = "Length")]
        public TimeSpan Length { get; set; }
        public virtual List<User> UsersWatched { get; set; }

    }
}