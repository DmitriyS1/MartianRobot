namespace MartianRobot.Models
{
    /// <summary>
    /// Cell model
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// X coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Shows that some robote got off the grid
        /// </summary>
        public bool IsScented { get; set; }

        public override string ToString()
        {
            return $"{Y}, {X}, {IsScented}";
        }
    }
}
