using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public class OrderDetail        
    {
        public int OrderDetailID { get; set; }
        public double TotalQty()
        {
            //return Qty * Price;
            return -1;
        }
        public int ItemPriceID { get; set; }

       // public int ItemId { get; set; }

        public virtual ItemPrice Itemprice { get; set; }
       // public virtual Item Item { get; set; }
    }
}
