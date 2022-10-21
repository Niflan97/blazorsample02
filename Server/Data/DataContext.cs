using System;
using blazorsample02.Shared;
using Microsoft.EntityFrameworkCore;

namespace blazorsample02.Server.Data
{
    public class DataContext : DbContext

    {

        private DataContext(DbContextOptions options) :base(options)
        {
            
        }

        


        public DbSet<Movies> Movie { get; set; }
    }
}

