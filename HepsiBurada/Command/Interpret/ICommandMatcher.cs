namespace HepsiBurada.Command.Interpret
{
    public interface ICommandMatcher
    {
        CommandType GetCommandType(string command);
    }
}