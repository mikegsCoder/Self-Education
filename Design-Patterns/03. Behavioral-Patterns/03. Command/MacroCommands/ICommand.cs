namespace MacroCommands
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
