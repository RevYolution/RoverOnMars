using System;
using Xunit;
using RoverOnMars;

namespace RoverTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSetXPosition()
        {
            //Arrange
            Rover testRover = new Rover();

            //Act
            testRover.Xposition = 5;

            //Assert
            Assert.Equal(5, testRover.Xposition);



        }
    }
}
