using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
