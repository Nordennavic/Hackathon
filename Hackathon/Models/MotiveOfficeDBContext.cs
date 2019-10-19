using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class MotiveOfficeDBContext : DbContext
    {
        MotiveOfficeDBContext()
        {
            Database.EnsureCreated();
        }
        public MotiveOfficeDBContext(DbContextOptions<MotiveOfficeDBContext> options) : base(options)
        {
        }

        /*public DbSet<DBStar> Stars { get; set; }
        public DbSet<DBPlanet> Planets { get; set; }*/
        public DbSet<DBUser> Users { get; set; }

        public const string ConnectionString =
            "Server=tcp:hackatonmotiv.database.windows.net,1433;Initial Catalog=DB_MOTIV;Persist Security Info=False;User ID=Hackaton;Password=Team2019;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }


}

