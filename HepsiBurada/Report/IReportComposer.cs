using System.Collections.Generic;
using HepsiBurada.LandingSurface;
using HepsiBurada.Rovers;

namespace HepsiBurada.Report
{
    public interface IReportComposer
    {
        string Compose(Point aPoint, CardinalDirection aCardinalDirection);
        string CompileReports(IEnumerable<IRover> rovers);
    }
}
