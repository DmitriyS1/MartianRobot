using MartianRobot.Interfaces;
using System;

namespace MartianRobot.Models
{
    public class Robot : IMessageSender, IMover
    {
        public int CurrentX { get; set; }

        public int CurrentY { get; set; }

        public char CurrentOrientation { get; set; }

        public void Move(char instruction)
        {
            switch(instruction)
            {
                case 'F':
                    break;
                case 'L':
                    break;
                case 'R':
                    break;
                default:
                    SendMessage("Error: Unsupported instruction");
                    break;
            }

        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
