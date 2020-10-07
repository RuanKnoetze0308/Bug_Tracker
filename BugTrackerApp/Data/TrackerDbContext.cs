using BugTrackerApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp.Data
{
    public class TrackerDbContext : IdentityDbContext
    {
        public TrackerDbContext(DbContextOptions<TrackerDbContext> options) :base(options)
        {

        }

        public DbSet<Bug> Bugs { get; set; }
    }
}
