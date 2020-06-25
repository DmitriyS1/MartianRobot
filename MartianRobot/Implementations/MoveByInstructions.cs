using MartianRobot.Helpers;
using MartianRobot.Interfaces;
using MartianRobot.Models;

namespace MartianRobot.Implementations
{
    public class MoveByInstructions : IMoveBehavior
    {
        public string Instructions { get; set; }

        public Position RobotPosition { get; set; }

        public CycleOrientation RobotOrientation { get; set; }

        public void Move()
        {
            var instructionsArray = InstructionsHelper.ParseInstructions(Instructions);
            foreach(var instruction in instructionsArray)
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
}
