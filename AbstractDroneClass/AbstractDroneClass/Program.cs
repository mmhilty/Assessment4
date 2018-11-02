namespace AbstractDroneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Single Responsibility Principle: The Drone class has the FlightSpeed method, which
             only does one thing - calculates that speed. Extending it seems to violate that 
             principle a bit, however, since it adds in changing values as well as calculating.
             Means that you'd have two reasons to need to change it - first if you wanted to 
             change the values differently, second if you wanted to do a different calculation.
             
            Open-Closed : using an abstract class is the base level way you get this done. 
             Extending the class lets us preserve everything about the drone, but then add some
             additional functionality in the Quadrotor class. 
             
             
             */

        }
    }
}
