using MartianRobot.Interfaces;
using System;

namespace MartianRobot.Models
{
    public class Robot : IMessageSender
    {
        private readonly IMoveBehavior _moveBehavior;

        public Position Position { get; set; }

        public EOrientation Orientation { get; set; }

        public Robot(IMoveBehavior moveBehavior)
        {
            _moveBehavior = moveBehavior;
        }

        public void Move()
        {
            _moveBehavior.Move();
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
