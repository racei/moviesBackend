using Saule;
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
        public string Title { get; set; }
        [Display(Name = "Year")]
        public int YearReleased { get; set; }
        [Display(Name = "Length")]
        public TimeSpan Length { get; set; }
        public List<User> UsersWatched { get; set; }

    }
    public class MovieResource : ApiResource
    {
        public MovieResource()
        {
            OfType("Movies");
            Attribute("Title");
            Attribute("YearReleased");
            Attribute("Length");
            WithId("ID");
            HasMany<UserResource>("Users");
        }

    }
}