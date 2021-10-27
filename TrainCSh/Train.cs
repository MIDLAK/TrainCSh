using System;
using System.Collections.Generic;
using System.Text;

namespace TrainCSh
{
    class Train
    {
        private TrainRoute route;
        private int trainID;
        private int capacity;   //вместимость поезда

        public Train() : this(new TrainRoute(), 1, 0) { }

        public Train(TrainRoute route, int trainID, int capacity)
        {
            if (route != null && IsValidTrainID(trainID) && IsValidCapacity(capacity))
            {
                this.route = route;
                this.trainID = trainID;
                this.capacity = capacity;
            } else
            {
                route = new TrainRoute();
                trainID = 1;
                capacity = 0;
            }
        }

        public int TrainID 
        {
            get 
            { 
                return trainID; 
            }

            set
            {
                if (IsValidTrainID(value))
                {
                    trainID = value;
                }
            } 
        }

        public int Capacity 
        {
            get
            {
                return capacity;
            }

            set
            {
                if (IsValidCapacity(value))
                {
                    capacity = value;
                }
            } 
        }

        public TrainRoute Route 
        {
            get
            {
                return route;
            }
            
            set
            {
                if (value != null)
                {
                    route = value;
                }
            } 
        }

        private bool IsValidCapacity(int capacity)
        {
            return capacity >= 0;
        }

        private bool IsValidTrainID(int trainID)
        {
            return trainID > 0;
        }

        public void Print()
        {
            Console.WriteLine("Номер поезда: {0}", trainID);
            route.Print();
        }
    }
}
