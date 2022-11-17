using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public IList<DateTime> GetFlightDates(String destination);

        public void GetFlights(string filterType, string filterValue);

        public IList<DateTime> GetFlightDates2(String destination);

        public void ShowFlightDetails(Plane plane);

        public int ProgrammedFlightNumber(DateTime startDate);

        double DurationAverage(string destination);

        public IList<Flight> OrderedDurationFlights();
        public void DestinationGroupedFlights();

    }
}
