using System;
using System.Collections.Generic;

namespace MarsRover
{
    public static class CalculateRoverPosition
    {
        public static void CalculateDirection(Rover rover, string rotation)
        {
            if (rotation == "L")
            {
                switch (rover.Direction)
                {
                    case "N":
                        rover.Direction = "W";
                        break;
                    case "S":
                        rover.Direction = "E";
                        break;
                    case "E":
                        rover.Direction = "N";
                        break;
                    case "W":
                        rover.Direction = "S";
                        break;
                    default:
                        break;
                }
            }

            if (rotation == "R")
            {
                switch (rover.Direction)
                {
                    case "N":
                        rover.Direction = "E";
                        break;
                    case "S":
                        rover.Direction = "W";
                        break;
                    case "E":
                        rover.Direction = "S";
                        break;
                    case "W":
                        rover.Direction = "N";
                        break;
                    default:
                        break;
                }
            }
        }

        public static void CalculateCoordinateX(Rover rover)
        {
            switch (rover.Direction)
            {
                case "E":
                    rover.CoordinateX += 1;
                    break;
                case "W":
                    rover.CoordinateX -= 1;
                    break;
            }
        }

        public static void CalculateCoordinateY(Rover rover)
        {
            switch (rover.Direction)
            {
                case "N":
                    rover.CoordinateY += 1;
                    break;
                case "S":
                    rover.CoordinateY -= 1;
                    break;
            }
        }
    }
}