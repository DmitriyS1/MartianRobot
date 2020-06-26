using MartianRobot.Implementations;
using MartianRobot.Models;
using System;

namespace MartianRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5 3
             * 1 1 E
             * FRLLFFRFLLRR
             */
            const string instructions = "RLFFRRFL";
            var position = new Position
            {
                CurrentX = 1,
                CurrentY = 2
            };
            var orientation = new CycleOrientation('E');
            var moveBehavior = new MoveByInstructions()
            {
                Instructions = instructions,
                RobotPosition = position,
                RobotOrientation = 
            };
            var r1 = new Robot(moveBehavior);
            grid.PrintGrid();

            Console.WriteLine("______________________________");

            grid2.PrintGrid();

            Console.ReadKey();
        }
    }
}
