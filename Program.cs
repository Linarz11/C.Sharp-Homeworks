using System;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            Military su_24 = new Military();
            su_24.Type = TypeMilitary.fighter;
            su_24.engine_count = 2;
            su_24.max_speed = 1315;
            su_24.pilot_seats_count = 2;

            Passenger_Plane tu_134 = new Passenger_Plane();
            tu_134.engine_count = 4;
            tu_134.max_speed = 950;
            tu_134.pilot_seats_count = 2;
            tu_134.Seats_count = 84;


        }
    }
}
