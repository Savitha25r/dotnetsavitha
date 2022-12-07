using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Movie_codefirstproject.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=Movies")
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<Movie_codefirstproject.displaymovie.displaymoviemodel> displaymoviemodels { get; set; }
    }
  

}