using System;
using System.Collections.Generic;
using MarsRover.Entities;
using MarsRover.Services;
using Xunit;

namespace MarsRover.Test
{
    public class CalculateTourTest
    {
        [Fact]
        public void TypeMaxCoordinatesAndRoverPositionsAndCommands_IfSuccess_ReturnRoverEntity()
        {
            var maxCoordinates = new List<int>() { 5, 5 };
            string[] startPosition = {"1", "2", "N"};
            var commands = "LMLMLMLMM";
            var actualOutput = new Rover()
            {
                CoordinateX = 1,
                CoordinateY = 3,
                Direction = "N"
            };
            var output = CalculateTour.TourCalculator(maxCoordinates, startPosition, commands);
            Assert.Equal(actualOutput.CoordinateX,output.CoordinateX);
            Assert.Equal(actualOutput.CoordinateY,output.CoordinateY);
            Assert.Equal(actualOutput.Direction,output.Direction);
        }
        
        [Fact]
        public void TypeMaxCoordinatesAfter_IfRoverPositionOutOfCoordinates_ThrowException()
        {
            var maxCoordinates = new List<int>() { 5, 5 };
            string[] startPosition = {"6", "2", "N"};
            var commands = "LMLMLMLMM";
            Assert.Throws<Exception>(() => CalculateTour.TourCalculator(maxCoordinates, startPosition, commands));
        }
        
        [Fact]
        public void TypeRoverCommandsAfter_IfRoverPositionOutOfCoordinates_ThrowException()
        {
            var maxCoordinates = new List<int>() { 5, 5 };
            string[] startPosition = {"3", "2", "N"};
            var commands = "MMMMMMMMM";
            Assert.Throws<Exception>(() => CalculateTour.TourCalculator(maxCoordinates, startPosition, commands));
        }
        
        [Fact]
        public void TypeRoverCoordinatesAfter_IfRoverCoordinateNegative_ThrowException()
        {
            var maxCoordinates = new List<int>() { 5, 5 };
            string[] startPosition = {"-3", "-2", "N"};
            var commands = "MM";
            Assert.Throws<Exception>(() => CalculateTour.TourCalculator(maxCoordinates, startPosition, commands));
        }
    }
}
