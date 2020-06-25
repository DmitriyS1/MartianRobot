using MartianRobot.Helpers;
using MartianRobot.Interfaces;
using MartianRobot.Models;

namespace MartianRobot.Implementations
{
    public class MoveByInstructions : IMoveBehavior
    {
        public string Instructions { get; set; }

        public Position RobotPosition { get; set; }

        public void Move()
        {
            var instructionsArray = InstructionsHelper.ParseInstructions(Instructions);
            foreach(var instruction in instructionsArray)
            {
                switch (instruction)
                {
                    case 'F':
                        if (RobotPosition.CurrentOrientation == 'N')
                        {
                            RobotPosition.CurrentY++;
                        }
                        else if (RobotPosition.CurrentOrientation == 'S')
                        {
                            RobotPosition.CurrentY--;
                        }
                        else if (RobotPosition.CurrentOrientation == 'E')
                        {
                            RobotPosition.CurrentX--;
                        }
                        else if (RobotPosition.CurrentOrientation == 'W')
                        {
                            RobotPosition.CurrentX++;
                        }

                        break;
                    case 'L':
                        break;
                    case 'R':
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
