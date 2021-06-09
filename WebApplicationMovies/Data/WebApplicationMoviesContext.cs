using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Models;

namespace MoviesWebApplication.Data
{
    public class MoviesWebApplicationContext : DbContext
    {
        public MoviesWebApplicationContext(DbContextOptions<MoviesWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesWebApplication.Models.Movie> Movie { get; set; }
    }
}
