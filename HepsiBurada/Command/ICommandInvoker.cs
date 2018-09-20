using System.Collections.Generic;
using HepsiBurada.LandingSurface;
using HepsiBurada.Rovers;

namespace HepsiBurada.Command
{
    public interface ICommandInvoker
    {
        void SetLandingSurface(ILandingSurface aLandingSurface);
        void SetRovers(IList<IRover> someRovers);
        void Assign(IEnumerable<ICommand> aCommandList);
        void InvokeAll();
    }
}