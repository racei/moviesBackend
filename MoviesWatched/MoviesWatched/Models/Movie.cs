using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWatched.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Movie Title")]
        public string title { get; set; }
        [Display(Name = "Year")]
        public int yearReleased { get; set; }
        [Display(Name = "Length")]
        public TimeSpan length { get; set; }
        public List<User> UsersWatched { get; set; }

    }
}