using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetmicroserviceone;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroserviceone
{
    public class ArticleDbContext:DbContext
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options ):base(options){}

        public DbSet<Article> articles{get;set;}
    }
}