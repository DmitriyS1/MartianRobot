using System;

namespace MartianRobot.Helpers
{
    /// <summary>
    /// Helper class for work with instructions
    /// </summary>
    public static class InstructionsHelper
    {
        public static char[] ParseInstructions(string instructions){
            if (instructions.Length > Restrictions.InstructionsLength)
            {
                throw new Exception("Instructions length too long");
            }

            return instructions.Trim().ToCharArray();
        }
    }
}
