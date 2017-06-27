using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Room
{
    public class RoomReservationDetail
    {
        public int RoomReservationDelailID { get; set; }

        public int RoomID { get; set; }

        public int ReservationID { get; set; }

        public int RoomCount { get; set; }

        public Double FullAmount { get; set; }

        public virtual RoomReservation RoomReservation { get; set; }
    }
}
