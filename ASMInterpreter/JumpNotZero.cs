using System;
using System.Collections.Generic;
using System.Text;

namespace ASMInterpreter
{
    internal class JumpNotZero : Instruction
    {
        public JumpNotZero(List<string> operands, Dictionary<string, int> memory) : base(operands, memory)
        {
        }

        public override int Execute()
        {
            string register = Operands[0];
            int jump = Int32.Parse(Operands[1]);
            int val;
            bool isConstant = Int32.TryParse(register, out val);

            if (!isConstant)
            {
                if (Memory.ContainsKey(register))
                {
                    val = Memory[register];
                }
                else
                {
                    throw new Exception($"no register found: {register}");
                }
            }

            return val == 0 ? 0 : jump;
        }
    }
}