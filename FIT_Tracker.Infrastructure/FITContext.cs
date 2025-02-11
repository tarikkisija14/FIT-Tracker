using FIT_Timer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_Tracker.Infrastructure
{
    public class FITContext : DbContext
    {
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["Fit_Tracker"].ConnectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }
        
        public DbSet<GodinaStudija> GodinaStudija { get; set; }

        public DbSet<Semestar> Semestri { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Sesija> Sesije { get; set; }


    }
}
