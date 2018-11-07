using AuthFun.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthFun.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenres> MovieGenres { get; set; }

        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
        }

    }
}
