using HepsiBurada.LandingSurface;
using HepsiBurada.Rovers;

namespace HepsiBurada.Command
{
    public interface IRoverDeployCommand : ICommand
    {
        Point DeployPoint { get; set; }
        CardinalDirection DeployDirection { get; set; }
        void SetReceivers(IRover aRover, ILandingSurface aLandingSurface);
    }
}