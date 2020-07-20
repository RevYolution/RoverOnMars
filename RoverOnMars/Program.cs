using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RoverOnMars
{
    class Program
    {
        static void Main(string[] args)
        {
            string roverImage = @"
    __  ___                   ____                          ______           __                 __  _           
   /  |/  /___ ___________   / __ \____ _   _____  _____   / ____/  ______  / /___  _________ _/ /_(_)___  ____ 
  / /|_/ / __ `/ ___/ ___/  / /_/ / __ \ | / / _ \/ ___/  / __/ | |/_/ __ \/ / __ \/ ___/ __ `/ __/ / __ \/ __ \
 / /  / / /_/ / /  (__  )  / _, _/ /_/ / |/ /  __/ /     / /____>  </ /_/ / / /_/ / /  / /_/ / /_/ / /_/ / / / /
/_/  /_/\__,_/_/  /____/  /_/ |_|\____/|___/\___/_/     /_____/_/|_/ .___/_/\____/_/   \__,_/\__/_/\____/_/ /_/ 
                                                                  /_/                                           
";
            Console.WriteLine(roverImage);
            RoverQuestions questions = new RoverQuestions();
            List<Rover> roverList = new List<Rover>();
            bool anotherRover = true;
            int[] plateuArea = questions.PlateuArea();

            try
            {
                while(anotherRover)
                {
                    Rover rover = new Rover();
                    rover.RoverMove(plateuArea, questions.RoverStartPosition(plateuArea), questions.MoveCommands());
                    roverList.Add(rover);
                    Console.WriteLine("Would you like to deploy another rover? Y/N");
                    char moreRovers = Convert.ToChar(Console.ReadLine().ToLower());
                    if(moreRovers == 'n')
                    {
                        anotherRover = false;
                    }
                }

                foreach (var item in roverList)
                {
                    
                    Console.WriteLine($"The rover is at ({item.Xposition}, {item.Yposition}) facing {item.Direction}");
                }
            }
            catch(Exception offPlateau)
            {
                Console.WriteLine(offPlateau.Message);
            }
        }
    }
}
