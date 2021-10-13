using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSongs.Models;

namespace WebSongs.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }
    }
}
