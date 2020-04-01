namespace Command.Command
{
    public interface ICommand
    {
        void ExecuteCommand();
        void UndoAction();
    }
}