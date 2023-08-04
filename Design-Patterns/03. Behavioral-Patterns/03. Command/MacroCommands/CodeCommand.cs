using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
