using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Room
{
    public class Facility
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public string Facilitys { get; set; }
        public double Charges { get; set; }
        public virtual RoomReservation RoomReservation { get; set; }

    }
}
