using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using dotnetmicroservicetwo.Models;

namespace dotnetmicroservicetwo.Models;

public class ReviewDbContext : DbContext
{
    public ReviewDbContext(DbContextOptions<ReviewDbContext> options ):base(options){}

    public DbSet<Review> reviews{get;set;}
}
