using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Restaurant
{
    public class RestaurantOrder:Order
    {
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public double Qty { get; set; }

        public int ReataurantOrderDetailID { get; set; }

        //public int ItemPrice { get; set; }

        public virtual ICollection<ReataurantOrderDetail> ReataurantOrderDetailModel { get; set; }
    }
}
