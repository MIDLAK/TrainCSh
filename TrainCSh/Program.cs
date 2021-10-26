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
            Console.WriteLine("Первый пассажир: {1} {0} и ему {2} лет", vadim.Name, vadim.FirstName, vadim.Age);
        }
    }
}
