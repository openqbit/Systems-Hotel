using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Room
{
    public class RoomReservation
    {
        public int RoomReservationID { get; set; }

        public int CustomerID { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public virtual ICollection<RoomReservationDetail> RoomReservationDetail { get; set; }
    }
}
