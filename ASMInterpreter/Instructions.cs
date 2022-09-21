using System.Collections.Generic;

namespace ASMInterpreter
{
    internal abstract class Instruction
    {
        public Instruction(List<string> operands, Dictionary<string, int> memory)
        {
            Operands = operands;
            Memory = memory;
        }

        protected List<string> Operands { get; private set; }
        protected Dictionary<string, int> Memory { get; private set; }

        public abstract int Execute();
    }
}