using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars
{
    interface IMoveRover
    {
        void RoverMove(int[] plateauArea, Tuple<int,int,string> startPosition, string commands);
    }
}
