using System;
using System.Collections.Generic;
using System.Text;

namespace TrainCSh
{
    class Depot
    {
        Train[] trains;

        public Depot(int parkingСapacity)
        {
            trains = new Train[parkingСapacity];
        }

        public void ToParkTrain(Train train)
        {
            if (train != null)
            {
                bool b = true;
                foreach (Train tr in trains)
                {
                    if (tr != null && tr.TrainID == train.TrainID)
                    {
                        b = false;
                    }
                }

                for (int i = 0, len = trains.Length; i < len; i++)
                {
                    if (trains[i] == null && b)
                    {
                        trains[i] = train;
                        break;
                    }
                }

                if (!b)
                {
                    throw new Exception("ОШИБКА! Парковка поезда с номером" + "\"" + train.TrainID + "\"" + "не удалась.");
                }
            }
        }


        public Train ToLeaveTrain(int trainID)
        {
            for (int i = 0, len = trains.Length; i < len; i++)
            {
                if (trains[i].TrainID == trainID)
                {
                    Train train = new Train(trains[i].Route, trains[i].TrainID, trains[i].Capacity);
                    trains[i] = null;
                    return train;
                }
            }
            throw new Exception("Поезда с таким ID в данном депо нет!");
        }

        public void Print()
        {
            Console.WriteLine("Все поезда, находящиеся в данный момет в депо: ");
            foreach (Train train in trains)
            {
                if (train != null)
                {
                    Console.WriteLine(train.TrainID);
                }
            }
        }
    }
}
