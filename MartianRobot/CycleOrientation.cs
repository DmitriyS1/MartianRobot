using MartianRobot.Models;

namespace MartianRobot
{
    public class CycleOrientation
    {
        public EOrientation CurrentOrientation { get; set; }

        public static CycleOrientation operator ++(CycleOrientation orientation)
        {
            if (orientation.CurrentOrientation >= EOrientation.West)
            {
                orientation.CurrentOrientation = EOrientation.North;
                return orientation;
            }
            else
            {
                orientation.CurrentOrientation++;
                return orientation;
            }
        }

        public static CycleOrientation operator --(CycleOrientation orientation)
        {
            if (orientation.CurrentOrientation <= EOrientation.North)
            {
                orientation.CurrentOrientation = EOrientation.West;
                return orientation;
            }
            else
            {
                orientation.CurrentOrientation--;
                return orientation;
            }
        }
    }
}
