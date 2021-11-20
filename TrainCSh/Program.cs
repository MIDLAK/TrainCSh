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


            DateTime dep1 = new DateTime(2021, 10, 30, 13, 38, 00);
            DateTime des1 = new DateTime(2021, 11, 1, 11, 01, 00);
            TrainRoute omskEkaterenburg = new TrainRoute("Барнаул", "Екатеринбург", dep1, des1);

            barnaulOmsk.Departure = "Барнаул";
            barnaulOmsk.Destination = "Омск";
            barnaulOmsk.DepartureDate = dep;
            barnaulOmsk.DestinationDate = des;

            Train train = new Train(barnaulOmsk, 12, 100);

            Console.WriteLine("Вместимость поезда ДО: " + train.Capacity);
            train++;
            Console.WriteLine("Вместимость поезда ПОСЛЕ: " + train.Capacity);

            Ticket ticket = new Ticket(700, 7, passenger, train);
            ticket.Print();
            TrainRoute.DateFormat = "yyyy-MM-dd HH:mm:ss";
            ticket.Print();

            train.Route = barnaulOmsk + omskEkaterenburg;   //перегрузка оператора '+'

        }
    }
}
