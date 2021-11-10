using System;
using System.Collections.Generic;
using System.Text;

namespace TrainCSh
{
    interface Observer
    {
        public void Update(TrainRoute route, int trainID, int capacity);
    }
}
