using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPressApp
{
    class NewsletterDB : DbContext
    {
        string connectionString = @"Server=.;Database=NewsletterDB;Trusted_Connection=True;";
        public DbSet<User> User { get; set; }
        public NewsletterDB() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
