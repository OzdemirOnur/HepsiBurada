using System;

namespace HepsiBurada.Command.Interpret
{
    [Serializable]
    public class CommandException : Exception
    {
        public CommandException(string message, Exception innerException) : base(message, innerException) {}
    }
}