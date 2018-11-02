using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    abstract class Drone
    {

        private int totalFlyTime;
        private int totalDistance;

        public Drone(int totalFlyTime, int totalDistance)
        {
            this.totalDistance = totalDistance;
            this.totalFlyTime = totalFlyTime;
        }

        public virtual int FlightSpeed(int totalDistance, int totalFlyTime)
        {
            int calculatedSpeed = totalDistance / totalFlyTime;
            return calculatedSpeed;
        }
       

    }
}
