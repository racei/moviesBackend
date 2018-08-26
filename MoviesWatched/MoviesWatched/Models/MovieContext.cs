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
            Database.Log = msg => System.Diagnostics.Debug.WriteLine(msg);
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }

    }
}