using System;
using System.Collections.Generic;
using System.Text;

namespace TrainCSh
{
    class Ticket : Observer
    {
        private int price;
        private int seat;
        private Passenger passenger;
        private Train train;

        public Ticket() : this(0, 0, new Passenger(), new Train()) { }

        public Ticket(int price, int seat, Passenger passenger, Train train)
        {
            this.Seat = seat;
            this.Price = price;
            this.Passenger = passenger;
            this.Train = train;
            if (train != null)
                train.RegisterObserver(this);   //регистрация наблюдателя
        }

        public int Price
        {
            get => price;
            set
            {
                if (IsValidPrice(value))
                {
                    price = value;
                }
            }
        }

        private bool IsValidPrice(int price)
        {
            return price >= 0;
        }

        public Passenger Passenger
        {
            get => passenger;

            set
            {
                if (value != null)
                {
                    passenger = value;
                }
            }
        }

        public Train Train
        {
            get => train;

            set
            {
                if (value != null)
                {
                    train = value;
                }
            }
        }

        public int Seat
        {
            get => seat;

            set
            {
                if (IsValidSeat(value))
                {
                    seat = value;
                }
            }
        }

        private bool IsValidSeat(int seat)
        {
            return seat > 0;
        }

        public void Print()
        {
            Console.WriteLine("-----------*БИЛЕТ*-----------");
            Console.WriteLine("Цена: {0} рублей", price);
            Console.WriteLine("Место: {0}", seat);
            passenger.Print();
            train.Print();
            Console.WriteLine("-----------------------------");
        }

        public void Update(TrainRoute route, int trainID, int capacity)
        {
            Console.WriteLine("\n-!-!-!-!-!-!-ВНИМАНИЕ-!-!-!-!-!-!-");
            Console.WriteLine("Произошло обновление информации в биллете. Ознакомтесь: ");
            this.Print();
            Console.WriteLine("\n");
        }
    }
}
