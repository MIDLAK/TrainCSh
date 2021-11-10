using System;

namespace TrainCSh
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            passenger.UserInput();

            TrainRoute barnaulOmsk = new TrainRoute();
            DateTime dep = new DateTime(2021, 10, 27, 13, 38, 00);
            DateTime des = new DateTime(2021, 10, 30, 11, 01, 00);

            barnaulOmsk.Departure = "Барнаул";
            barnaulOmsk.Destination = "Омск";
            barnaulOmsk.DepartureDate = dep;
            barnaulOmsk.DestinationDate = des;

            Train train = new Train(barnaulOmsk, 12, 100);

            Ticket ticket = new Ticket(700, 7, passenger, train);
            ticket.Print();

            train.TrainID = 55;

        }
    }
}
