namespace MacroCommands
{
    public class CEO
    {
        ICommand command;

        public void SetCommand(ICommand comm)
        {
            command = comm;
        }

        public void StartProject()
        {
            if (command != null)
            {
                command.Execute();
            }
        }

        public void StopProject()
        {
            if (command != null)
            {
                command.Undo();
            }
        }
    }
}
