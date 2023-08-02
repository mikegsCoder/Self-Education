﻿namespace Command
{
    public class Invoker
    {
        Command command;

        public void SetCommand(Command c)
        {
            command = c;
        }

        public void Run()
        {
            command.Execute();
        }

        public void Cancel()
        {
            command.Undo();
        }
    }
}
