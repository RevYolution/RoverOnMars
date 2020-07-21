using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

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
                Console.WriteLine("");
                Console.WriteLine($"---{input} is not a valid positive integer. Please enter a valid positive integer.");
                Console.Write("> ");
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
                Console.WriteLine("");
                Console.WriteLine("---Please enter a single letter direction (N/S/E/W).");
                Console.Write("> ");
                input = Console.ReadLine();
            }

            while(Regex.IsMatch(input, @"[^NnSsEeWw]"))
            {
                Console.WriteLine("");
                Console.WriteLine($"---Please enter a compass direction (N/S/E/W). {input} is not a valid direction.");
                Console.Write("> ");
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
            Console.Write("> ");
            string plateauWidthInput = Console.ReadLine();

            

            int plateuWidth = Convert.ToInt32(IsValidNumber(plateauWidthInput));
            Console.WriteLine("");
            Console.WriteLine("Provide the height of exploration area as a positive integer.");
            Console.Write("> ");
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
            Console.WriteLine("");
            Console.WriteLine("The following will set deployment of a Rover.\n Deployment will continue until you no longer want to deploy a rover \n or a set of movement commands moves a rover out of the plateau area bounds.");
            Thread.Sleep(5000);
            Console.WriteLine("");
            Console.WriteLine("========================================================");
            Console.WriteLine($"Provide the starting latitude position of the rover as a positive integer between 0 and {areaBounds[0]}.");
            Console.Write("> ");
            string startingXInput = Console.ReadLine();
            int startingX = Convert.ToInt32(IsValidNumber(startingXInput));
            while(startingX > areaBounds[0] || startingX < 0)
            {
                while(startingX > areaBounds[0])
                {
                    Console.WriteLine("");
                    Console.WriteLine($"---The starting latitude cannot be larger than {areaBounds[0]}");
                    Console.WriteLine("========================================================");
                    Console.WriteLine($"Please enter a starting latitude less than {areaBounds[0]}");
                    Console.Write("> ");
                    startingXInput = Console.ReadLine();
                    startingX = Convert.ToInt32(IsValidNumber(startingXInput));
                }
                while (startingX < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"---The starting latitude cannot be less than 0");
                    Console.WriteLine("========================================================");
                    Console.WriteLine($"Please enter a starting latitude greater than 0");
                    Console.Write("> ");
                    startingXInput = Console.ReadLine();
                    startingX = Convert.ToInt32(IsValidNumber(startingXInput));
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Provide the starting longitude position of the rover as a positive integer between 0 and {areaBounds[1]}.");
            Console.Write("> ");
            string startingYInput = Console.ReadLine();
            int startingY = Convert.ToInt32(IsValidNumber(startingYInput));
            while(startingY > areaBounds[1] || startingY < 0)
            {
                while (startingY > areaBounds[1])
                {
                    Console.WriteLine("");
                    Console.WriteLine($"---The starting longitude cannot be larger than {areaBounds[1]}");
                    Console.WriteLine("========================================================");
                    Console.WriteLine($"Please enter a starting longitude less than {areaBounds[1]}");
                    Console.Write("> ");
                    startingYInput = Console.ReadLine();
                    startingY = Convert.ToInt32(IsValidNumber(startingYInput));
                }
                while (startingY < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"---The starting longitude cannot be less than 0");
                    Console.WriteLine("========================================================");
                    Console.WriteLine($"Please enter a starting longitude greater than 0");
                    Console.Write("> ");
                    startingYInput = Console.ReadLine();
                    startingY = Convert.ToInt32(IsValidNumber(startingYInput));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Provide the starting direction of the rover. (N/S/E/W)");
            Console.Write("> ");
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

            Console.WriteLine("========================================================");
            Console.WriteLine("Example movement command string: mmlmmr");
            Console.WriteLine("");
            Console.WriteLine("Actions performed: \n move 1 in direction facing, \n move 1 in direction facing, \n turn left 90 degrees, \n move 1 in direction facing, \n move 1 in direction facing, \n turn right 90 degrees.");
            Thread.Sleep(2500);
            Console.WriteLine("");
            Console.WriteLine("Enter in your move commands (m/M = move, l/L = turn Left, r/R = turn Right)");
            Console.Write("> ");
            string moveCommands = Console.ReadLine().ToLower();
            return moveCommands;
        }
    }
}
