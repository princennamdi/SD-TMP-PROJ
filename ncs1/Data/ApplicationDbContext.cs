using com.sun.jdi;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ncs1.Models;
using ncs1.Models.CommandNg;
using ncs1.Models.Entry;
using ncs1.Models.Location;
using ncs1.Models.StationNg;
using ncs1.Models.Zones;

namespace ncs1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<MyUser> MyUsers { get; set; }
        public DbSet<CommandNg> CommandNgs { get; set; }
        public DbSet<StationNg> StationNgs { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<EntryCategory> EntryCategories { get; set; }
        public DbSet<LocationNg> LocationNgs { get; set; }
        public DbSet<ZoneNg> Zones { get; set; }


    }



}
