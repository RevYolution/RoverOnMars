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

        [Theory]
        [InlineData(Direction.N)]
        [InlineData(Direction.S)]
        [InlineData(Direction.E)]
        [InlineData(Direction.W)]
        public void CanGetSetDirection(Direction testDirection)
        {
            //Arrange
            Rover testRover = new Rover();

            //Act
            testRover.Direction = testDirection;

            //Assert
            Assert.Equal(testDirection, testRover.Direction);
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

        [Fact]
        public void CanMoveRoverFrom_12N_To_13N()
        {
            //Arrange
            Rover testRover = new Rover();
            int[] testArea = new int[] { 5, 5 };
            Tuple<int, int, string> testStart = new Tuple<int, int, string>(1, 2, "N");
            string testCommands = "lmlmlmlmm";

            Rover expectedRover = new Rover();
            expectedRover.Xposition = 1;
            expectedRover.Yposition = 3;
            expectedRover.Direction = Direction.N;

            //Act
             testRover.RoverMove(testArea, testStart, testCommands);

            //Assert
            //Assert.Equal<Rover>(expectedRover, testRover);
            Assert.Equal(1, testRover.Xposition);
            Assert.Equal(3, testRover.Yposition);
            Assert.Equal(Direction.N, testRover.Direction);
        }

        [Fact]
        public void CanMoveRoverFrom_33E_To_51N()
        {
            //Arrange
            Rover testRover = new Rover();
            int[] testArea = new int[] { 5, 5 };
            Tuple<int, int, string> testStart = new Tuple<int, int, string>(3, 3, "E");
            string testCommands = "mmrmmrmrrm";

            Rover expectedRover = new Rover();
            expectedRover.Xposition = 5;
            expectedRover.Yposition = 1;
            expectedRover.Direction = Direction.E;

            //Act
            testRover.RoverMove(testArea, testStart, testCommands);

            //Assert
            //Assert.Equal<Rover>(expectedRover, testRover);
            Assert.Equal(5, testRover.Xposition);
            Assert.Equal(1, testRover.Yposition);
            Assert.Equal(Direction.E, testRover.Direction);
        }

    }
}
