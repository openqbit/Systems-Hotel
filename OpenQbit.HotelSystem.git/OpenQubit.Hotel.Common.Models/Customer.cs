using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public class Customer 
    {
        public int CustomerId { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
