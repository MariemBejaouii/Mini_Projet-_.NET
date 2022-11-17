using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData

    {

        public static Plane p1 = new Plane
        {
            Capacity = 150,
            PlaneType = PlaneType.Boing,
            ManifactureDate = new DateTime(2015, 02, 03)

        };

        public static Plane p2 = new Plane
        {
            Capacity = 250,
            PlaneType = PlaneType.Airbus,
            ManifactureDate = new DateTime(2020, 11, 11)


        };

        public static Stuff Stuff1 = new Stuff
        
        { FullName = new FullName
        {
            FirstName = "captain",
            LastName = "captain"

        },
            
            EmailAdresse = "Captain.captain@gmail.com ",
            BirthDate = new DateTime(1965, 01, 01),
            EmployementDate = new DateTime(1999, 01, 01),
            Salary = 99999


        };

        public static Stuff Stuff2 = new Stuff

        {
            FullName = new FullName
            {
                FirstName = "hostess1",
                LastName = "hostess1"

            },
           
            EmailAdresse = "hostess1.hostess1@gmail.com ",
            BirthDate = new DateTime(1995, 01, 01),
            EmployementDate = new DateTime(2000, 01, 01),
            Salary = 999


        };

        public static Stuff Stuff3 = new Stuff


        {
            FullName = new FullName
            {
                FirstName = "hostess2",
                LastName = "hostess2"

            },
            
            EmailAdresse = "hostess2.hostess2@gmail.com ",
            BirthDate = new DateTime(1995, 01, 01),
            EmployementDate = new DateTime(2000, 01, 01),
            Salary = 999


        };


        public static Traveller Traveller1 = new Traveller {

            FullName = new FullName
            {
                FirstName = "Traveller1",
                LastName = "Traveller1"

            },
           
            EmailAdresse = "Traveller1.Traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation = "No troubles ",
            Nationality = "American"

        };

        public static Traveller Traveller2 = new Traveller
        {

            FullName = new FullName
            {
                FirstName = "Traveller2",
                LastName = "Traveller2"

            },

         
            EmailAdresse = "Traveller2.Traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "Some troubles ",
            Nationality = "French"

        };

        public static Traveller Traveller3 = new Traveller
        {

            FullName = new FullName
            {
                FirstName = "Traveller3",
                LastName = "Traveller3"

            },
            EmailAdresse = "Traveller3.Traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "No troubles ",
            Nationality = "Tunisian"

        };
        public static Traveller Traveller4 = new Traveller
        {

            FullName = new FullName
            {
                FirstName = "Traveller4",
                LastName = "Traveller4"

            },
            EmailAdresse = "Traveller4.Traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "Some troubles ",
            Nationality = "American"

        };
        public static Traveller Traveller5 = new Traveller
        {

            FullName = new FullName
            {
                FirstName = "Traveller5",
                LastName = "Traveller5"

            },
            EmailAdresse = "Traveller5.Traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some troubles ",
            Nationality = "Spanish"

        };


        public static Flight f1 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01),
            MyPlan = p1,
            EstimatedDuration = 110
            /*    Passengers = new List<Passenger>()
                {
                    Traveller1, Traveller2,Traveller3,Traveller4,Traveller5}
            */

        };

        public static Flight f2 = new Flight
        {
            FlightDate = new DateTime(2022, 02, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01),
            MyPlan = p2,
            EstimatedDuration = 105



        };

        public static Flight f3 = new Flight
        {
            FlightDate = new DateTime(2022, 03, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01),
            MyPlan = p2,
            EstimatedDuration = 100



        };

        public static Flight f4 = new Flight
        {
            FlightDate = new DateTime(2022, 04, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 04, 01),
            MyPlan = p2,
            EstimatedDuration = 130



        };

        public static Flight f5 = new Flight
        {
            FlightDate = new DateTime(2022, 05, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 05, 01),
            MyPlan = p2,
            EstimatedDuration = 105



        };

        public static Flight f6 = new Flight
        {
            FlightDate = new DateTime(2022, 06, 01),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 06, 01),
            MyPlan = p2,
            EstimatedDuration = 200





        };


        public static List<Flight> listFlights = new List<Flight>
        {
            f1,f2,f3,f4,f5,f6
        };






    }
}
