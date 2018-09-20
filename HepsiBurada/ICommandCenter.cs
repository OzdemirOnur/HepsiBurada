using HepsiBurada.LandingSurface;

namespace HepsiBurada
{
    public interface ICommandCenter
    {
        void Execute(string commandString);
        ILandingSurface GetLandingSurface();
        string GetCombinedRoverReport();
    }
}
