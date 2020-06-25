using MartianRobot.Interfaces;
using System;

namespace MartianRobot.Models
{
    public class Robot : IMessageSender
    {
        public Position Position { get; set; }

        public EOrientation Orientation { get; set; }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
