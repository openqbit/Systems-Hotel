using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Kitchen
{
    public class KitchenOrder
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public int OrderID { get; set; } 
    }
}
