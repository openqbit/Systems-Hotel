using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Room
{
    public class Service
    {

        public int ID { get; set; }
        public int ReservationID { get; set; }
        public string Services { get; set; }
        public double Charges { get; set; }
        public virtual RoomReservation RoomReservation { get; set; }

    }
}
