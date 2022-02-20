using MarsRover.Constants;
using MarsRover.Entities;

namespace MarsRover.Services
{
    public static class CalculateRoverPosition
    {
        public static void CalculateDirection(Rover rover, string rotation)
        {
            if (rotation == RotationConstant.Left)
            {
                switch (rover.Direction)
                {
                    case DirectionConstant.North:
                        rover.Direction = DirectionConstant.West;
                        break;
                    case DirectionConstant.South:
                        rover.Direction = DirectionConstant.East;
                        break;
                    case DirectionConstant.East:
                        rover.Direction = DirectionConstant.North;
                        break;
                    case DirectionConstant.West:
                        rover.Direction = DirectionConstant.South;
                        break;
                }
            }

            if (rotation == RotationConstant.Right)
            {
                switch (rover.Direction)
                {
                    case DirectionConstant.North:
                        rover.Direction = DirectionConstant.East;
                        break;
                    case DirectionConstant.South:
                        rover.Direction = DirectionConstant.West;
                        break;
                    case DirectionConstant.East:
                        rover.Direction = DirectionConstant.South;
                        break;
                    case DirectionConstant.West:
                        rover.Direction = DirectionConstant.North;
                        break;
                }
            }
        }

        public static void CalculateCoordinateX(Rover rover)
        {
            switch (rover.Direction)
            {
                case DirectionConstant.East:
                    rover.CoordinateX += 1;
                    break;
                case DirectionConstant.West:
                    rover.CoordinateX -= 1;
                    break;
            }
        }

        public static void CalculateCoordinateY(Rover rover)
        {
            switch (rover.Direction)
            {
                case DirectionConstant.North:
                    rover.CoordinateY += 1;
                    break;
                case DirectionConstant.South:
                    rover.CoordinateY -= 1;
                    break;
            }
        }
    }
}