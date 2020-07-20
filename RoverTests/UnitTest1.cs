using System;
using Xunit;
using RoverOnMars;

namespace RoverTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetSetXPosition()
        {
            //Arrange
            Rover testRover = new Rover();

            //Act
            testRover.Xposition = 5;

            //Assert
            Assert.Equal(5, testRover.Xposition);
        }

        [Fact]
        public void CanGetSetYPosition()
        {
            //Arrange
            Rover testRover = new Rover();

            //Act
            testRover.Yposition = 10;

            //Assert
            Assert.Equal(10, testRover.Yposition);
        }

        [Fact]
        public void CanGetSetDirection()
        {
            //Arrange
            Rover testRover = new Rover();

            //Act
            testRover.Direction = Direction.N;

            //Assert
            //Assert.Equal('N', testRover.Direction);
        }

        [Fact]
        public void CanMoveRoverNorth()
        {
            //Arrange
            Rover testRover = new Rover();
            int[] testArea = new int[] { 5, 5 };
            Tuple<int, int, string> testStart = new Tuple<int, int, string>(0, 0, "N");
            string testCommands = "mm";

            //Act
            testRover.RoverMove(testArea, testStart, testCommands);

            //Assert
            Assert.Equal(2, testRover.Yposition);
        }

        [Fact]
        public void CanMoveRoverSouth()
        {
            //Arrange
            Rover testRover = new Rover();
            int[] testArea = new int[] { 5, 5 };
            Tuple<int, int, string> testStart = new Tuple<int, int, string>(0, 2, "S");
            string testCommands = "mm";

            //Act
            testRover.RoverMove(testArea, testStart, testCommands);

            //Assert
            Assert.Equal(0, testRover.Yposition);
        }

        [Fact]
        public void CanMoveRoverEast()
        {
            //Arrange
            Rover testRover = new Rover();
            int[] testArea = new int[] { 5, 5 };
            Tuple<int, int, string> testStart = new Tuple<int, int, string>(0, 0, "E");
            string testCommands = "mm";

            //Act
            testRover.RoverMove(testArea, testStart, testCommands);

            //Assert
            Assert.Equal(2, testRover.Xposition);
        }

        [Fact]
        public void CanMoveRoverWest()
        {
            //Arrange
            Rover testRover = new Rover();
            int[] testArea = new int[] { 5, 5 };
            Tuple<int, int, string> testStart = new Tuple<int, int, string>(2, 0, "W");
            string testCommands = "mm";

            //Act
            testRover.RoverMove(testArea, testStart, testCommands);

            //Assert
            Assert.Equal(0, testRover.Xposition);
        }
    }
}
