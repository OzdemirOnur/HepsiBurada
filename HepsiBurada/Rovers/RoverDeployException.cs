using System;

namespace HepsiBurada.Rovers
{
    [Serializable]
    public class RoverDeployException : Exception
    {
        public RoverDeployException(string message) : base(message) { }
    }
}