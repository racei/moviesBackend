using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWatched.Models
{
    [JsonObject(Title = "User")]
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<Movie> MoviesWatched { get; set; }
    }

}