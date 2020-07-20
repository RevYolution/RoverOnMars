using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars
{

    public class Rover : IMoveRover
    {
        public int Xposition { get; set; }

        public int Yposition { get; set; }

        public Direction Direction { get; set; }

        /// <summary>
        /// Runs when command string contains a l and resets the direction based off current direction.
        /// </summary>
        private void TurnLeft()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    this.Direction = Direction.W;
                    break;
                case Direction.S:
                    this.Direction = Direction.E;
                    break;
                case Direction.E:
                    this.Direction = Direction.N;
                    break;
                case Direction.W:
                    this.Direction = Direction.S;
                    break;
            }
        }

        /// <summary>
        /// Runs when command string contains a r and resets the direction based off current direction. 
        /// </summary>
        private void TurnRight()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    this.Direction = Direction.E;
                    break;
                case Direction.S:
                    this.Direction = Direction.W;
                    break;
                case Direction.E:
                    this.Direction = Direction.S;
                    break;
                case Direction.W:
                    this.Direction = Direction.N;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Runs when the command string contains a m and moves the rover according to its facing direction. 
        /// </summary>
        private void Move()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    this.Yposition += 1;
                    break;
                case Direction.S:
                    this.Yposition -= 1;
                    break;
                case Direction.E:
                    this.Xposition += 1;
                    break;
                case Direction.W:
                    this.Xposition -= 1;
                    break;
                default:
                    break;
            }
        }

        public void RoverMove(int[] plateauArea, Tuple<int,int,string> startPosition, string commands)
        {
            this.Xposition = startPosition.Item1;
            this.Yposition = startPosition.Item2;
            this.Direction = (Direction)Enum.Parse(typeof(Direction), startPosition.Item3);
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'm':
                        this.Move();
                        break;
                    case 'r':
                        this.TurnRight();
                        break;
                    case 'l': TurnLeft();
                        break;
                    default:
                        Console.WriteLine($"{command} is not a valid command. {command} ignored.");
                        break;
                }

                if(this.Xposition < 0 || this.Xposition > plateauArea[0] || this.Yposition < 0 || this.Yposition > plateauArea[1])
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Commands drove rover off the plateau: Rover Deployment Terminated.");
                    Console.WriteLine("=================================================");
                    Console.WriteLine("=================================================");
                    throw new Exception($"The rover drove off the plateau! Position ({this.Xposition}, {this.Yposition}) is outside of ({plateauArea[0]},{plateauArea[1]})");
                }
            }
        }
    }

    public enum Direction
    {
        N = 1,
        S = 2,
        E = 3,
        W = 4
    }
}
