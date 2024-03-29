﻿namespace MacroCommands
{
    public class AdvertiseCommand : ICommand
    {
        SalesManager manager;

        public AdvertiseCommand(SalesManager m)
        {
            manager = m;
        }

        public void Execute()
        {
            manager.StartAdvertize();
        }

        public void Undo()
        {
            manager.StopAdvertize();
        }
    }
}
