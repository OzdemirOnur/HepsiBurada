using System.Collections.Generic;
using HepsiBurada.Rovers;

namespace HepsiBurada.Command
{
    public interface IRoverExploreCommand : ICommand
    {
        IList<Movement> Movements { get; }
        void SetReceiver(IRover aRover);
    }
}