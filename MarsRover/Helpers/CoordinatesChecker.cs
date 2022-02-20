using System;
using System.Collections.Generic;
using MarsRover.Constants;

namespace MarsRover.Helpers
{
    public static class CoordinatesChecker
    {
        public static void CheckCoordinates(int currentX, int currentY, List<int> maxCoordinate)
        {
            if (currentX > maxCoordinate[0] || currentY > maxCoordinate[1] || currentX < 0 || currentY < 0)
            {
                throw new Exception(MessageConstant.OutOfCoordinatesExceptionMessage);
            }
        }
    }
}