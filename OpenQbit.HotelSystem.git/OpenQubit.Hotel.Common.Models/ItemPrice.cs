using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public class ItemPrice
    {
        public int ItemPriceId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public double Price { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }

    }
}
