﻿using System;
using Microsoft.EntityFrameworkCore;

namespace webApi.Data.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}

