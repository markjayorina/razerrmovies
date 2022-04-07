#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razerrmovies.Models;

namespace razerrmovies.Data
{
    public class razerrmoviesContext : DbContext
    {
        public razerrmoviesContext (DbContextOptions<razerrmoviesContext> options)
            : base(options)
        {
        }

        public DbSet<razerrmovies.Models.Movie> Movie { get; set; }
    }
}
