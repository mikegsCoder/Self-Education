namespace MacroCommands
{
    public class CodeCommand : ICommand
    {
        Developer dev;

        public CodeCommand(Developer d)
        {
            dev = d;
        }

        public void Execute()
        {
            dev.StartCoding();
        }

        public void Undo()
        {
            dev.StopCoding();
        }
    }
}
