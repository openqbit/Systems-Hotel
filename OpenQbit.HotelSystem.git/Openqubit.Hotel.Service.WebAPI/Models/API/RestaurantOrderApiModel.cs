using OpenQubit.Hotel.Common.Models;
using OpenQubit.Hotel.Common.Models.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Openqubit.Hotel.Service.WebAPI.Models.API
{
    public class RestaurantOrderApiModel
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public double Qty { get; set; }
        public int ItemId { get; set; }
        public int OrderTypeID { get; set; }
        public virtual Employee employee { get; set; }
        public virtual Item Item { get; set; }
        public virtual OrderType OrderType { get; set; }
        public virtual Customer customer { get; set; }
        public virtual ICollection<ReataurantOrderDetail> ReataurantOrderDetail { get; set; }
    }
}