using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPages_Movie.Models
{
    public class RazorPages_MovieContext : DbContext
    {
        public RazorPages_MovieContext (DbContextOptions<RazorPages_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
