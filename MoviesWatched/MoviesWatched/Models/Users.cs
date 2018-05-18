using Saule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWatched.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Movie> MoviesWatched { get; set; }
    }

    public class UserResource : ApiResource
    {
        public UserResource()
        {
            WithId("ID");
            Attribute("Name");
        }
    }
}