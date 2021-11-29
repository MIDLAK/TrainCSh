using System;

namespace TrainCSh
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            while (true)
            {
                try
                {
                    passenger.UserInput();
                    break;
                } catch
                {
                    Console.WriteLine("ВНИМАНИЕ! Произошла ошибка при вводе.Пожалуйста, повторите его.");
                }
            }
            

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


            Console.WriteLine("-----------*Демонстрация конструктора*-----------");
            Train train = new Train();
            train.Print();
            Console.WriteLine("-------------------------------------------------");
            train = new Train(25);
            train.Print();
            Console.WriteLine("-------------------------------------------------");
            train = new Train(barnaulOmsk, 12, 100);
            train.Print();
            Console.WriteLine("-------------------------------------------------");

            Train train1 = new Train(56);
            Train train2 = new Train(77);
            Train train3 = new Train(81);

            Depot depot = new Depot(3);
            depot.ToParkTrain(train1);
            depot.ToParkTrain(train2);
            depot.ToParkTrain(train3);

            depot.Print();

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
