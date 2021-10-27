using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TrainCSh
{
    class TrainRoute
    {
        private string departure;
        private string destination;
        private DateTime departureDate;
        private DateTime destinationDate;

        private string dateFormat = "dd.MM.yyyy HH:mm";


        public TrainRoute() : this("-", "-", new DateTime(), new DateTime()) { }

        public TrainRoute(string departure, string destination, DateTime departureDate, DateTime destinationDate)
        {
            if (IsValidDeparture(departure) && IsValidDestination(destination) && departureDate != null && destinationDate != null)
            {
                this.departure = departure;
                this.destination = destination;
                this.departureDate = departureDate;
                this.destinationDate = destinationDate;
            } else
            {
                this.departure = "-";
                this.destination = "-";
                this.departureDate = new DateTime();
                this.destinationDate = new DateTime();
            }
        }

        public void Print()
        {
            Console.WriteLine("Дата отправления: {0}", departureDate.ToString(dateFormat));
            Console.WriteLine("Дата прибытия: {0}", destinationDate.ToString(dateFormat));
            TimeSpan travel = TravelTime();
            Console.WriteLine("Время в пути: {0} дней, {1} часов, {2} минут", travel.Days, travel.Hours, travel.Minutes);
        }

        private TimeSpan TravelTime()
        {
            TimeSpan travel = destinationDate.Subtract(departureDate);
            return travel;
        }

        public string Departure 
        {
            get
            {
                return departure;
            }

            set
            {
                if (IsValidDeparture(value))
                {
                    departure = value;
                }
            }
        }

        public string Destination 
        {
            get
            {
                return destination;
            }

            set
            {
                if (IsValidDestination(value))
                {
                    destination = value;
                }
            } 
        }

        public DateTime DepartureDate 
        {
            get
            {
                return departureDate;
            }

            set
            {
                if (value != null)
                {
                    departureDate = value;
                }

            } 
        }

        public DateTime DestinationDate 
        {
            get
            {
                return destinationDate;
            }

            set
            {
                if (destinationDate != null)
                {
                    destinationDate = value;
                }
            } 
        }

        private bool IsValidDeparture(string departure)
        {
            return departure.Trim().Length > 0;
        }

        private bool IsValidDestination(string destination)
        {
            return destination.Trim().Length > 0;
        }
    }
}
