using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public class OrderDetail : Item
    {
        public double TotalQty()
        {
            //return Qty * Price;
            return -1;
        }  
    }
}
