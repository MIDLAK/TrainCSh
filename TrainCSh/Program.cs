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
        }
    }
}
