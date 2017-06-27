using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Room
{
    public class Tour
    {
        public int TourID { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
