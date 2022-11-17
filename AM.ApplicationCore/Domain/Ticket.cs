using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket

    {

        public double Prix { get; set; }

        public int Siege { get; set; }

        public bool VIP { get; set; }

        public virtual Passenger?  MyPassenger { get; set; }


        public string? PassengerFK { get; set; }
        [ForeignKey("PassengerFK")]

        public int FlightFK { get; set; }
        [ForeignKey("FlightFK")]

        public virtual Flight? MyFlight { get; set; }

    }
}

