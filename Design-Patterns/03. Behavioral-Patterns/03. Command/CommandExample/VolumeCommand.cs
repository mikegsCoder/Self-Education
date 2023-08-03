using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class VolumeCommand : ICommand
    {
        Volume volume;

        public VolumeCommand(Volume v)
        {
            volume = v;
        }

        public void Execute()
        {
            volume.RaiseLevel();
        }

        public void Undo()
        {
            volume.DropLevel();
        }
    }
}
