﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMovies.Models;

namespace MyMovies.Data
{
    public class MyMoviesContext : DbContext
    {
        public MyMoviesContext (DbContextOptions<MyMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MyMovies.Models.Movie> Movie { get; set; }

        public DbSet<MyMovies.Models.Member> Member { get; set; }
    }
}
