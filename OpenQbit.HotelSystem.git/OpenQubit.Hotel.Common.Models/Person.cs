using OpenQubit.Hotel.Common.Models.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        //   public string Position { get; set; }
        public int TourID { get; set; }
       
        public string NIC { get; set; }
        public int Contact { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
