using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrainCSh
{
    class Train : Subject
    {
        private TrainRoute route;
        private int trainID;
        private int capacity;   //вместимость поезда

        private List<Observer> observers;   //массив наблюдателей

        public Train() : this(new TrainRoute(), 1, 0) { }

        public Train(TrainRoute route, int trainID, int capacity)
        {
            observers = new List<Observer>();

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
                    MeasurementsChanged();
                }
            } 
        }

        public static Train operator ++(Train train)
        {
            train.Capacity += 100;  //добавляем вагон к поезду
            return train;
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
                    MeasurementsChanged();
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
                    MeasurementsChanged();
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

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void NotifyObservers()
        {
            for(int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(route, trainID, capacity);
            }
        }
        
        /*оповещение наблюдателей об изменении*/
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
