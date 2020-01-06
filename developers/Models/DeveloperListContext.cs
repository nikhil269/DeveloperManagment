using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace developers.Models
{
    public class DeveloperListContext : DbContext
    {
        public DeveloperListContext(DbContextOptions<DeveloperListContext> options) : base(options)
        {
        }
        public DbSet<DeveloperList> DeveloperLists { get; set; }
        public DbSet<DeveloperList> Developer { get; set; }
    }
}
