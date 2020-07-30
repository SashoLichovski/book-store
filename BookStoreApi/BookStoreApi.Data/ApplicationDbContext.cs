using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<HistoryBook> HistoryBooks { get; set; }
        public DbSet<FantasyBook> FantasyBooks { get; set; }
        public DbSet<ClassicBook> ClassicBooks { get; set; }
    }
}
