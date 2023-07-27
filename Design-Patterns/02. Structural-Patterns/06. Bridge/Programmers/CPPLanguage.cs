using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Using C++ compiller to create binary code.");
        }

        public void Execute()
        {
            Console.WriteLine("Executing binary code.");
        }
    }
}
