namespace MacroCommands
{
    public class TestCommand : ICommand
    {
        QAEngineer qa;

        public TestCommand(QAEngineer q)
        {
            qa = q;
        }

        public void Execute()
        {
            qa.StartTest();
        }

        public void Undo()
        {
            qa.StopTest();
        }
    }
}
