using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }
        public int ItemId { get; set; }
        public int OrderTypeID { get; set; }
        public virtual Item Item { get; set; }
        public virtual OrderType OrderType { get; set; }
    }
}
