using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Using Roslyn compiller to produce exe file.");
        }

        public void Execute()
        {
            Console.WriteLine("JIT compiles to binary code.");
            Console.WriteLine("CLR executes the binary code.");
        }
    }
}
