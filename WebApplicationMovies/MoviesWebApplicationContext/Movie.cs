using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }
    }
}
