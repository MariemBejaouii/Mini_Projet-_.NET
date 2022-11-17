using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System.Numerics;
using Plane = AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Services
{

    public class ServiceFlight : IServiceFlight
    {

        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;

        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {

            IList<DateTime> dates = new List<DateTime>();

            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)

                {
                    dates.Add(flight.FlightDate);
                }

            }
            return dates;
        }







        public void GetFlights(string filterType, string filerValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filerValue)
                        {
                            System.Console.WriteLine(f);
                        }
                    }
                    break;
                case "Date":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate.Equals(DateTime.Parse(filerValue)))


                            System.Console.WriteLine(f);


                    }
                    break;
                case "EstimatedDuration":
                    foreach (Flight f in Flights)
                    {

                        if (f.FlightDate.Equals(int.Parse(filerValue)))



                            System.Console.WriteLine(f);

                    }
                    break;
            }
        }


        // III Le langage LINQ

        public IList<DateTime> GetFlightDates2(string destination)
        {

            /*    var query = from f in Flights
                            where f.Destination == destination
                            select f.FlightDate;
                return query.ToList();*/

            var reqLambda = Flights.Where(f => f.Destination == destination)
                .Select(f =>f.FlightDate);
            return reqLambda.ToList();
        }





        public void ShowFlightDetails(Plane plane)
        {



            /* var req = from f in Flights
                       where f.MyPlan == plane
                       select f;

             foreach (var f in req)
             {
                 Console.WriteLine(f.FlightDate + "  " + f.Destination);
             }*/

            var req = Flights
                .Where(f => f.MyPlan == plane)
                .Select(f => f);
            foreach(var flight in req)
            {
                Console.WriteLine(flight.FlightDate + "  " + flight.Destination);
            }




        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /*   var req = from f in Flights
                         where (f.FlightDate - startDate).TotalDays < 7 && (f.FlightDate - startDate).TotalDays >= 0
                         select f;
               return req.Count();*/

            return Flights
                .Where(f => (f.FlightDate - startDate).TotalDays < 7 && (f.FlightDate - startDate).TotalDays >= 0)
                .Select(f => f).Count();



        }




        public double DurationAverage(string destination)
        {

            /*  var req = from f in Flights
                        where (f.Destination == destination)
                        select f.EstimatedDuration;

              return req.Average();*/

            return Flights
                .Where(f=>f.Destination == destination)
                .Select(f => f.EstimatedDuration).Average();

        }



        public IList<Flight> OrderedDurationFlights()
        {
            /*  var req = from flight in Flights
                        orderby flight.EstimatedDuration descending
                        select flight;
              return req.ToList();*/

            return Flights.OrderByDescending(f => f.EstimatedDuration).ToList();

        }


     /*   public IList<Traveller> SeniorTravellers(Flight flight)
        {
            // var req = from p in flight.Passengers.OfType<Traveller>()
            // orderby p.BirthDate
            // select p;
           //  return req.Take(3).ToList();

             

            return flight.Passengers.OfType<Traveller>().OrderBy(p => p.BirthDate).Take(3).ToList();



        }*/
        public void DestinationGroupedFlights() {
            /*
                        var req = from f in Flights
                                  group f by f.Destination;*/

            var req = Flights.GroupBy(f => f.Destination);


            foreach (var g in req)
            {

                Console.WriteLine("Destination : " + g.Key);


                foreach (var flight in g)
                {

                    Console.WriteLine("Décollage :" + flight.FlightDate);


                }
            } }




        public ServiceFlight()
        {
            /*
                        FlightDetailsDel = ShowFlightDetails;
                        DurationAverageDel = DurationAverage;

                        */

            FlightDetailsDel = p =>
            {

                var req = from f in Flights
                          where f.MyPlan == p
                          select f;

                foreach (var f in req)
                {
                    Console.WriteLine(f.FlightDate + "  " + f.Destination);
                }


            };

            DurationAverageDel = d =>
            {
                var req = from f in Flights
                          where (f.Destination == d)
                          select f.EstimatedDuration;

                return req.Average();
            };
        }
    }




}
