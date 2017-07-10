using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Room
{
    public class RoomOrder
    {
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public double Qty { get; set; }

        public int ItemPrice { get; set; }

        public virtual ICollection<OrderDetail> OrderDetailModel { get; set; }
    }
}
