using System;
using System.Collections.Generic;

namespace ASMInterpreter
{
    internal class Move : Instruction
    {
        public Move(List<string> operands, Dictionary<string, int> memory) : base(operands, memory)
        {
        }

        public override int Execute()
        {
            string register = Operands[0];
            string operand = Operands[1];
            int val;
            bool isConstant = Int32.TryParse(operand, out val);

            if (isConstant)
            {
                if (Memory.ContainsKey(register))
                {
                    Memory[register] = val;
                }
                else
                {
                    Memory.Add(register, val);
                }
            }
            else
            {
                if (Memory.ContainsKey(operand))
                {
                    Memory[register] = Memory[operand];
                }
                else
                {
                    throw new Exception($"Move.Execute(), no register by name {operand}");
                }
            }

            return 1;
        }
    }
}