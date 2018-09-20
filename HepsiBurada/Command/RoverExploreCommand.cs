using System.Collections.Generic;
using HepsiBurada.Rovers;

namespace HepsiBurada.Command
{
    public class RoverExploreCommand : IRoverExploreCommand
    {
        public IList<Movement> Movements { get; private set; }
        private IRover rover;
        
        public RoverExploreCommand(IList<Movement> someMovements)
        {
            Movements = someMovements;
        }

        public CommandType GetCommandType()
        {
            return CommandType.RoverExploreCommand;
        }

        public void Execute()
        {
            rover.Move(Movements);
        }

        public void SetReceiver(IRover aRover)
        {
            rover = aRover;
        }
    }
}
