using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RoverOnMars
{
    /// <summary>
    /// Class that contains the questions to set up the Rover class.
    /// </summary>
    class RoverQuestions
    {
        /// <summary>
        /// Validates if a user input is only a string of numbers.
        /// </summary>
        /// <param name="input">String input to be verified</param>
        /// <returns>String that contains only numbers</returns>
        private string IsValidNumber(string input)
        {
            while (Regex.IsMatch(input, @"^\d+$") == false)
            {
                Console.WriteLine($"{input} is not a valid positive integer. Please enter a valid positive integer.");
                input = Console.ReadLine();
            }

            return input;
        }

        /// <summary>
        /// Validates if a user input is a single direction string.
        /// </summary>
        /// <param name="input">String input to be verified</param>
        /// <returns>Single letter string that gives rover facing direction</returns>
        private string IsOnlyDirection(string input)
        {
            while(input.Length > 1 || input.Length == 0)
            {
                Console.WriteLine("Please enter a single letter direction (N/S/E/W).");
                input = Console.ReadLine();
            }

            while(Regex.IsMatch(input, @"[^NnSsEeWw]"))
            {
                Console.WriteLine($"Please enter a compass direction (N/S/E/W). {input} is not a valid direction.");
                input = Console.ReadLine();
            }

            return input;
        }

        /// <summary>
        /// Prompts user for the plateau search area.
        /// </summary>
        /// <returns>int[] of height and width of the plateau area</returns>
        public int[] PlateauArea()
        {
            int[] plateauAreaInput = new int[2];
            Console.WriteLine("Welcome! Please provide the search area you would like to explore today.");
            Console.WriteLine("Provide the width of exploration area as a positive integer.");
            string plateauWidthInput = Console.ReadLine();

            

            int plateuWidth = Convert.ToInt32(IsValidNumber(plateauWidthInput));
            Console.WriteLine("Provide the height of exploration area as a positive integer.");
            string plateauHeightInput = Console.ReadLine();
            int plateuHeight = Convert.ToInt32(IsValidNumber(plateauHeightInput));
            plateauAreaInput[0] = plateuWidth;
            plateauAreaInput[1] = plateuHeight;
            return plateauAreaInput;
        }

        /// <summary>
        /// Prompts user for where a rover is to start within the bounds of the plateau area and which direction the rover is facing.
        /// </summary>
        /// <param name="areaBounds">Plateau area bounds</param>
        /// <returns>Tuple of the int x position, int y position and string of the facing direction</returns>
        public Tuple<int,int,string> RoverStartPosition(int[] areaBounds)
        {
            Console.WriteLine($"Provide the starting latitude position of the rover as a positive integer between 0 and {areaBounds[0]}.");
            string startingXInput = Console.ReadLine();
            int startingX = Convert.ToInt32(IsValidNumber(startingXInput));
            while(startingX > areaBounds[0] || startingX < 0)
            {
                while(startingX > areaBounds[0])
                {
                    Console.WriteLine($"The starting latitude cannot be larger than {areaBounds[0]}");
                    Console.WriteLine("====================================");
                    Console.WriteLine($"Please enter a starting latitude less than {areaBounds[0]}");
                    startingX = Convert.ToInt32(Console.ReadLine());
                }
                while (startingX < 0)
                {
                    Console.WriteLine($"The starting latitude cannot be less than 0");
                    Console.WriteLine("====================================");
                    Console.WriteLine($"Please enter a starting latitude greater than 0");
                    startingX = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"Provide the starting longitude position of the rover as a positive integer between 0 and {areaBounds[1]}.");
            string startingYInput = Console.ReadLine();
            int startingY = Convert.ToInt32(IsValidNumber(startingYInput));
            while(startingY > areaBounds[1] || startingY < 0)
            {
                while (startingY > areaBounds[1])
                {
                    Console.WriteLine($"The starting longitude cannot be larger than {areaBounds[1]}");
                    Console.WriteLine("====================================");
                    Console.WriteLine($"Please enter a starting longitude less than {areaBounds[1]}");
                    startingY = Convert.ToInt32(Console.ReadLine());
                }
                while (startingY < 0)
                {
                    Console.WriteLine($"The starting longitude cannot be less than 0");
                    Console.WriteLine("====================================");
                    Console.WriteLine($"Please enter a starting longitude greater than 0");
                    startingY = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("What direction is the rover facing? (N/S/E/W)");
            string startingDirectionInput = Console.ReadLine();
            string startingDirection = IsOnlyDirection(startingDirectionInput).ToUpper();

            Tuple<int, int, string> startPosition = new Tuple<int, int, string>(startingX, startingY, startingDirection);

            return startPosition;
            
        }

        /// <summary>
        /// Prompts the user to enter in a string of move commands
        /// </summary>
        /// <returns>String of move commands</returns>
        public string MoveCommands()
        {
            Console.WriteLine("Enter in your move commands (m/M = move, l/L = turn Left, r/R = turn Right)");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");
            Console.WriteLine("Sample commands: mmlmmr.");
            Console.WriteLine("Actions performed: move 1 in direction facing, move 1 in direction facing, turn left 90 degrees, move 1 in direction facing, move 1 in direction facing, turn right 90 degrees.");
            string moveCommands = Console.ReadLine().ToLower();
            return moveCommands;
        }
    }
}
