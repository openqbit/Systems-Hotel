using OpenQubit.Hotel.Common.Models;
using OpenQubit.Hotel.Common.Models.Finance;
using OpenQubit.Hotel.Common.Models.Management;
using OpenQubit.Hotel.Common.Models.Room;
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

        public DbSet<Facility> Facility { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<RoomReservation> RoomReservation { get; set; }
        public DbSet<RoomReservationDetail> RoomReservationDetail { get; set; }
        public DbSet<Tour> Tour { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<Payment> Payment { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    
    
    }
}
