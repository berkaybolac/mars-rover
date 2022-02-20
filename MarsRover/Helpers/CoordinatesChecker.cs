using System;
using System.Collections.Generic;

namespace MarsRover
{
    public static class CoordinatesChecker
    {
        public static void CheckCoordinates(int currentX, int currentY, List<int> maxCoordinate)
        {
            if (currentX > maxCoordinate[0] ||  currentY > maxCoordinate[1])
            {
                throw new Exception("The vehicle cannot be positioned out of coordinates.");
            }
        }
    }
}