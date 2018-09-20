using System;

namespace HepsiBurada.Report
{
    [Serializable]
    public class ReportException : Exception
    {
        public ReportException(string message) : base(message) { }
    }
}