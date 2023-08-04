using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroCommands
{
    public class MacroCommand : ICommand
    {
        List<ICommand> commands;

        public MacroCommand(List<ICommand> comms)
        {
            commands = comms;
        }

        public void Execute()
        {
            foreach (ICommand c in commands)
            {
                c.Execute();
            }
        }

        public void Undo()
        {
            foreach (ICommand c in commands)
            {
                c.Undo();
            }
        }
    }
}
