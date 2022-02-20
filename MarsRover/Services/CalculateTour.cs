using System;
using System.Collections.Generic;
using MarsRover.Constants;
using MarsRover.Entities;
using MarsRover.Helpers;

namespace MarsRover.Services
{
    public static class CalculateTour
    {
        public static Rover TourCalculator(List<int> maxCoordinate, string[] startPositions, string movingCommands)
        {
            var rover = new Rover();
            rover.CoordinateX = Convert.ToInt32(startPositions[0]);
            rover.CoordinateY = Convert.ToInt32(startPositions[1]);
            rover.Direction = startPositions[2];
            CoordinatesChecker.CheckCoordinates(rover.CoordinateX, rover.CoordinateY, maxCoordinate);
            foreach (var commands in movingCommands)
            {
                switch (commands.ToString())
                {
                    case RotationConstant.Moving:
                        CalculateRoverPosition.CalculateCoordinateX(rover);
                        CalculateRoverPosition.CalculateCoordinateY(rover);
                        CoordinatesChecker.CheckCoordinates(rover.CoordinateX, rover.CoordinateY, maxCoordinate);
                        break;
                    case RotationConstant.Left:
                        CalculateRoverPosition.CalculateDirection(rover, commands.ToString());
                        break;
                    case RotationConstant.Right:
                        CalculateRoverPosition.CalculateDirection(rover, commands.ToString());
                        break;
                }
            }
            Console.WriteLine(
                $"CoordinateX : {rover.CoordinateX}, CoordinateY : {rover.CoordinateY}, Direction: {rover.Direction}");
            return rover;
        }
    }
}