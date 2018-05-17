using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesWatched.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {

        }
        DbSet<Movie> Movies { get; set; }
        DbSet<User> Users { get; set; }
    }
}