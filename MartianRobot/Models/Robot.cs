using MartianRobot.Interfaces;
using System;

namespace MartianRobot.Models
{
    public class Robot : IMessageSender
    {
        public Position Position { get; set; }

        public void Move(char instruction)
        {
            switch(instruction)
            {
                
            }

        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
