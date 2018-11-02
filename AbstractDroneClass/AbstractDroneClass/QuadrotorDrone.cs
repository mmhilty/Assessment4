using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClass
{
    class QuadrotorDrone : Drone
    {
        private int totalDistance;
        private int totalFlyTime;

        public QuadrotorDrone(int totalFlyTime, int totalDistance) : base(totalFlyTime,totalDistance)
        {
            this.totalDistance = totalDistance;
            this.totalFlyTime = totalFlyTime;
        }

        public override int FlightSpeed(int totalDistance1, int totalFlyTime1)
        {
            totalDistance = totalDistance + totalDistance1;
            totalFlyTime = totalFlyTime + totalFlyTime1;
            int calculatedSpeed = totalDistance / totalFlyTime;
            return calculatedSpeed;
        }


    }
}
