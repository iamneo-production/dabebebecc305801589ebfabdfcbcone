using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroserviceone.Models;

public class ArticleDbContext:DbContext
{
    public ArticleDbContext(DbContextOptions<ArticleDbContext> options ):base(options){}

    public DbSet<Article> articles{get;set;}
}
