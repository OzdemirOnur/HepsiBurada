using System.Collections.Generic;

namespace HepsiBurada.Command.Interpret
{
    public interface ICommandParser
    {
        IEnumerable<ICommand> Parse(string commandString);
    }
}
