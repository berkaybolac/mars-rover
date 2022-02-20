namespace MarsRover.Constants
{
    public static class MessageConstant
    {
        public const string PleaseTypeMaxCoordinates = "Please Type Max X Coordinate, Max Y Coordinate, For Example: '5 5' ";
        public const string PleaseTypeRoverPosition = "Please Type Rover X Coordinate, Rover Y Coordinate, Rover Direction  For Example: '1 2 N' ";
        public const string PleaseTypeTravelCommands = "Rover travel commands For Example: 'LMLMLMLMM' ";
        public const string ExitAndCalculate = "Please press A to CALCULATE and EXIT, press ENTER to continue.";
        public const string OutOfCoordinatesExceptionMessage = "The vehicle cannot be positioned out of coordinates.";
    }
}