using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ConcreteCommand : Command
    {
        Receiver receiver;

        public ConcreteCommand(Receiver r)
        {
            receiver = r;
        }

        public override void Execute()
        {
            receiver.Operation();
        }

        public override void Undo()
        { }
    }
}
