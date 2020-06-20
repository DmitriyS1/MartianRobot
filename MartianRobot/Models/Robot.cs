using MartianRobot.Interfaces;
using System;

namespace MartianRobot.Models
{
    public class Robot : IMessageSender
    {

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
