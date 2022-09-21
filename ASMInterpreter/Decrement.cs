using System;
using System.Collections.Generic;
using System.Text;

namespace ASMInterpreter
{
    internal class Decrement : Instruction
    {
        public Decrement(List<string> operands, Dictionary<string, int> memory) : base(operands, memory)
        {
        }

        public override int Execute()
        {
            string register = Operands[0];

            if (Memory.ContainsKey(register))
            {
                --Memory[register];
            }
            else
            {
                throw new Exception($"Decrement.Execute(), no register by name {register}");
            }

            return 1;
        }
    }
}