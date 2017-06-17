using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public abstract class Item
    {
        public  int ID { get; set; }
        public  string Name { get; set; }
        public string Category { get; set; }
        public  double Price { get; set; }
        public  string Description { get; set; }
        public int Qty { get; set; }
    }
}
