// See https://aka.ms/new-console-template for more information



using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, World!");


/*Plane p1 = new Plane();

p1.Capacity = 300;
p1.PlaneType = PlaneType.Airbus;
p1.ManifactureDate = DateTime.Now;
 Console.WriteLine("p1 "+p1.ToString()));

Plane p2 = new Plane(PlaneType.Boing, 500, DateTime.Now);
Console.WriteLine("p2 " + p2.ToString());




Plane p3 = new Plane()
{

    Capacity = 500,
    PlaneType = PlaneType.Airbus,
    ManifactureDate = DateTime.Now

};

Console.WriteLine("p3 " + p3.ToString());

*/

/*Passenger pass1 = new Passenger
{
    FirstName = "Mariem",
    LastName = "Bejaoui",
    EmailAdresse = "mariem.bejaoui@yahoo.fr"

};

Console.WriteLine(pass1.CheckProfile("Mariem", "Bejaoui", "salma.bejaoui@yahoo.fr")); //false

Console.WriteLine(pass1.CheckProfile("Mariem", "Bejaoui", "mariem.bejaoui@yahoo.fr")); //true

Traveller tr = new Traveller();


pass1.PassengerType();

tr.PassengerType();
*/

//TestData td = new TestData();
ServiceFlight SF = new ServiceFlight();
SF.Flights = TestData.listFlights;
foreach (var item in SF.GetFlightDates("Paris"))
{
    Console.WriteLine("item :"+item);
}

//SF.GetFlights();

foreach (var item in SF.GetFlightDates2("Madrid"))
{
    Console.WriteLine("item2 :" + item);
}

SF.ShowFlightDetails(TestData.p1);
Console.WriteLine("DurationAverage  "+SF.DurationAverage("Paris"));


SF.DestinationGroupedFlights();
foreach(var flight in SF.OrderedDurationFlights())
{
    Console.WriteLine(flight);
}

/*foreach (var flight in SF.SeniorTravellers(TestData.f1))
{
    Console.WriteLine(flight);
}*/

Console.WriteLine("Les vols par Destionation  :");

SF.DestinationGroupedFlights();


Passenger passs2 = new Passenger
{
    FullName =new FullName
    { FirstName = "mariem",
    LastName = "bejaoui"}
    
,


};


Console.WriteLine("AVANT");
Console.WriteLine(passs2.ToString());
passs2.UpperFullName();
Console.WriteLine("APRES");
Console.WriteLine(passs2.ToString());
Console.WriteLine("aaaaaaa   test");
AMContext context = new AMContext();
context.Flights.Add(TestData.f3);
context.SaveChanges();
Console.WriteLine(  context.Flights.First().MyPlan.Capacity);




