using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace FuneralServices
{
    class AppCont : DbContext
    {
        public DbSet<user> users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RitualGod> RitualGods { get; set; }
        public DbSet<FunrService> FunrServices { get; set; }
        public DbSet<Coffin> Coffins { get; set; }
        public DbSet<Wreath> Wreaths { get; set; }
        public DbSet<Crosse> Crosses { get; set; }
        public DbSet<FuneralC> FuneralCs { get; set; }
        public DbSet<TheFuneral> TheFunerals { get; set; }
        public DbSet<Hearse> Hearses { get; set; }
        public DbSet<Monument> Monuments { get; set; }
        public DbSet<Worker> Workers { get; set; }
     



        /// <summary>
        /// ////////////////////////////////////
        /// </summary>
        public AppCont() : base("DefaultConnection") { }

    }
}
