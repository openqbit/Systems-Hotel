using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Models.Finance
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public int ReservationDetailID { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public Double FullAmount { get; set; }
    }
}
