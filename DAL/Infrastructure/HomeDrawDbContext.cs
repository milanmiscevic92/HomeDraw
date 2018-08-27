using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Domain.Entities;
using Domain.Entities.Bathroom;
using Domain.Entities.ConstructionElements;
using Domain.Entities.Kitchen;
using Domain.Entities.LivingRoom;

using Microsoft.AspNet.Identity;

namespace DAL.Infrastructure
{
    public class HomeDrawDbContext : IdentityDbContext<AppUser>
    {
        public HomeDrawDbContext() : base("HomeDrawDb") { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Bath> Baths { get; set; }
        public DbSet<Lavatory> Lavatories { get; set; }
        public DbSet<Shower> Showers { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Wall> Walls { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<Refrigerator> Refrigerators { get; set; }
        public DbSet<Sink> Sinks { get; set; }
        public DbSet<Stove> Stoves { get; set; }
        public DbSet<Sofa> Sofas { get; set; }
        public DbSet<Table> Tables { get; set; }



        public static HomeDrawDbContext Create()
        {
            return new HomeDrawDbContext();
        }

        public class HomeDrawDbInit : DropCreateDatabaseIfModelChanges<HomeDrawDbContext>
        {
            protected override void Seed(HomeDrawDbContext context)
            {
                base.Seed(context);
            }
        }


    }

}
