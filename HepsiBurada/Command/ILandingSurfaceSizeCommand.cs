using HepsiBurada.LandingSurface;

namespace HepsiBurada.Command
{
    public interface ILandingSurfaceSizeCommand : ICommand
    {
        Size Size { get; }
        void SetReceiver(ILandingSurface aLandingSurface);
    }
}