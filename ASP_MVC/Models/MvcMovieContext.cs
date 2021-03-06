﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC.Models
{
    public class MvcMovieContext: DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options): base(options)
        {
        }

        public DbSet<ASP_MVC.Models.Movie> Movie { get; set; }
    }
}
