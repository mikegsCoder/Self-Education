using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {}

        public void Undo()
        {}
    }
}
