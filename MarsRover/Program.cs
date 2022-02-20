using System;
using System.Collections.Generic;
using System.Linq;
using MarsRover.Constants;
using MarsRover.Services;

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool keepInput = true;
            Console.WriteLine(MessageConstant.PleaseTypeMaxCoordinates);
            var maxCoordinates = Console.ReadLine()?.Trim().Split(' ').Select(int.Parse).ToList();
            var startPositionList = new List<string[]>();
            var commandsList = new List<string>();

            while (keepInput)
            {
                Console.WriteLine(MessageConstant.PleaseTypeRoverPosition);
                var startPositions = Console.ReadLine()?.ToUpper().Trim().Split(' ');
                startPositionList.Add(startPositions);

                Console.WriteLine(MessageConstant.PleaseTypeTravelCommands);
                var commands = Console.ReadLine()?.ToUpper();
                commandsList.Add(commands);

                Console.WriteLine(MessageConstant.ExitAndCalculate);
                if (Console.ReadKey().Key != ConsoleKey.A) continue;
                for (var i = 0; i < startPositions.Length; i++)
                {
                    CalculateTour.TourCalculator(maxCoordinates, startPositionList[i], commandsList[i]);
                }

                keepInput = Console.ReadKey().Key != ConsoleKey.A;
            }
        }
    }
}