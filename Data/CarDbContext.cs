﻿using CarAppRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace CarAppRazor.Data;

public class CarDbContext : DbContext
{
    public CarDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }
}