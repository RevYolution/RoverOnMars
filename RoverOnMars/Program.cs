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
            string resultImage = @"
    ____                          ____             __                                 __     ____                  ____      
   / __ \____ _   _____  _____   / __ \___  ____  / /___  __  ______ ___  ___  ____  / /_   / __ \___  _______  __/ / /______
  / /_/ / __ \ | / / _ \/ ___/  / / / / _ \/ __ \/ / __ \/ / / / __ `__ \/ _ \/ __ \/ __/  / /_/ / _ \/ ___/ / / / / __/ ___/
 / _, _/ /_/ / |/ /  __/ /     / /_/ /  __/ /_/ / / /_/ / /_/ / / / / / /  __/ / / / /_   / _, _/  __(__  ) /_/ / / /_(__  ) 
/_/ |_|\____/|___/\___/_/     /_____/\___/ .___/_/\____/\__, /_/ /_/ /_/\___/_/ /_/\__/  /_/ |_|\___/____/\__,_/_/\__/____/  
                                        /_/            /____/                                                                
";
            Console.WriteLine(roverImage);
            RoverQuestions questions = new RoverQuestions();
            List<Rover> roverList = new List<Rover>();
            bool anotherRover = true;
            int[] plateauArea = questions.PlateauArea();

            try
            {
                while(anotherRover)
                {
                    Rover rover = new Rover();
                    rover.RoverMove(plateauArea, questions.RoverStartPosition(plateauArea), questions.MoveCommands());
                    roverList.Add(rover);
                    Console.WriteLine("Would you like to deploy another rover? Y/N");
                    char moreRovers = Convert.ToChar(Console.ReadLine().ToLower());
                    if(moreRovers == 'n')
                    {
                        anotherRover = false;
                    }
                }

                
            }
            catch(Exception offPlateau)
            {
                Console.WriteLine(offPlateau.Message);
            }

            Console.WriteLine(resultImage);
            foreach (var item in roverList)
            {
                int counter = 1;
                Console.WriteLine($"Rover {counter} is at ({item.Xposition}, {item.Yposition}) facing {item.Direction}");
            }
        }
    }
}
