namespace MartianRobot.Interfaces
{
    /// <summary>
    /// Interface to send messages
    /// </summary>
    public interface IMessageSender
    {
        /// <summary>
        /// Send message method
        /// </summary>
        void SendMessage(string message);
    }
}
