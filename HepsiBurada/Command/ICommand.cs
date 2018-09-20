namespace HepsiBurada.Command
{
    public interface ICommand
    {
        CommandType GetCommandType();
        void Execute();
    }
}
