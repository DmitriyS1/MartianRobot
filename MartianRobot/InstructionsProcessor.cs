using MartianRobot.Models;

namespace MartianRobot
{
    public class InstructionsProcessor
    {
        public Grid Grid { get; set; }

        public Position GetPosition(char instruction, Position currentPosition)
        {
            switch (instruction)
            {
                case 'F':
                    if (RobotOrientation.CurrentOrientation == EOrientation.North)
                    {
                        RobotPosition.CurrentY++;
                    }
                    else if (RobotOrientation.CurrentOrientation == EOrientation.South)
                    {
                        RobotPosition.CurrentY--;
                    }
                    else if (RobotOrientation.CurrentOrientation == EOrientation.East)
                    {
                        RobotPosition.CurrentX--;
                    }
                    else if (RobotOrientation.CurrentOrientation == EOrientation.West)
                    {
                        RobotPosition.CurrentX++;
                    }

                    break;
                case 'L':
                    RobotOrientation--;
                    break;
                case 'R':
                    RobotOrientation++;
                    break;
                default:
                    break;
            }
        }
    }
}
