using OpenQubit.Hotel.Common.Models;
using OpenQubit.Hotel.Common.Models.Kitchen;
using OpenQubit.Hotel.Common.Models.Management;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.DAL.DataAccess
{
   public class HotelContext : DbContext
    {
        public HotelContext() : base("HotelDB")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<ItemPrice> ItemPrice { get; set; }
        public DbSet<JobType> JobType { get; set; }
        public DbSet<KitchenOrder> KichanOrder { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    
    
    }
}
