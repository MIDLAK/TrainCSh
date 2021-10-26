using System;

namespace TrainCSh
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger vadim = new Passenger("Вадим", "Калга", 19);
            vadim.FirstName = "Калуга";
            Passenger passenger = new Passenger();
            passenger.UserInput();
            vadim.Print();
            passenger.Print();

            DateTime day1 = new DateTime(2021, 10, 26, 21, 59, 0);
            DateTime day2 = new DateTime(2021, 10, 30, 12, 17, 0);
            TrainRoute route = new TrainRoute("Барнаул", "Омск", day1, day2);
            route.Print();




        }
    }
}
