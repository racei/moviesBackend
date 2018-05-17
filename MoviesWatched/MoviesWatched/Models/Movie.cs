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
        public string title { get; set; }
        public int yearReleased { get; set; }
        public TimeSpan length { get; set; }
        //Add user connection

    }
}