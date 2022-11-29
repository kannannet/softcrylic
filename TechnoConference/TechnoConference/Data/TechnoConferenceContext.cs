using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechnoConference.Models;

namespace TechnoConference.Data
{
    public class TechnoConferenceContext : DbContext
    {
        public TechnoConferenceContext (DbContextOptions<TechnoConferenceContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite("Data Source=testDB.db");
        }


        public DbSet<TechnoConference.Models.Events> Events { get; set; } = default!;
    }
}
