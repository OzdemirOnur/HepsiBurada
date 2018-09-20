using System.Collections.Generic;
using HepsiBurada.LandingSurface;

namespace HepsiBurada.Rovers
{
    public interface IRover
    {
        Point Position { get; set; }
        CardinalDirection CardinalDirection { get; set; }
        void Deploy(ILandingSurface aLandingSurface, Point aPoint, CardinalDirection aDirection);
        void Move(IEnumerable<Movement> movements);
        bool IsDeployed();
    }
}