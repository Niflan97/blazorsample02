using System;
using blazorsample02.Shared;
using Microsoft.EntityFrameworkCore;

namespace blazorsample02.Server.Data
{
    public class DataContext : DbContext

    {

        public DataContext(DbContextOptions options, DbSet<Movies> movie) :base(options)
        {
            Movie = movie;
        }

        


        public DbSet<Movies> Movie { get; set; }
    }
}

