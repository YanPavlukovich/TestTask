using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASMInterpreter
{
    internal class Increment : Instruction
    {
        public Increment(List<string> operands, Dictionary<string, int> memory) : base(operands, memory)
        {
        }

        public override int Execute()
        {
            string register = Operands[0];

            if (Memory.ContainsKey(register))
            {
                ++Memory[register];
            }
            else
            {
                throw new Exception($"Increment.Execute(), no register by name {register}");
            }

            return 1;
        }
    }
}