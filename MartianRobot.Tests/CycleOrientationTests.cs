using MartianRobot.Models;
using Xunit;

namespace MartianRobot.Tests
{
    public class CycleOrientationTests
    {
        [Fact]
        public void IncrementOperator_ShouldReturnNorth_IfCurrentOrientationIsWest()
        {
            var orientation = new CycleOrientation { CurrentOrientation = EOrientation.West };

            orientation++;

            Assert.Equal(EOrientation.North, orientation.CurrentOrientation);
        }

        [Fact]
        public void DecrementOperator_ShouldReturnNorth_IfCurrentOrientationIsEast()
        {
            var orientation = new CycleOrientation { CurrentOrientation = EOrientation.East };

            orientation--;

            Assert.Equal(EOrientation.North, orientation.CurrentOrientation);
        }
    }
}
