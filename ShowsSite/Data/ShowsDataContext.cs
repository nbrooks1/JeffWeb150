using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowsSite.Data
{
    public class ShowsDataContext : DbContext
    {

        public ShowsDataContext(DbContextOptions<ShowsDataContext> options): base(options)
        {

        }
        public DbSet<Show> Shows { get; set; }
    }
}
