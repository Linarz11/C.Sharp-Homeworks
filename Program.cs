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
            su_24.mac_speed = 1315;
            su_24.pilot_seats_count = 2;


        }
    }
}
