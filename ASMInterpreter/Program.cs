using System;
using System.Collections.Generic;
using System.Linq;

namespace ASMInterpreter
{
    public class Program
    {
        public Program(string[] instructions)
        {
            foreach (string instruction in instructions)
            {
                LoadInstruction(instruction);
            }
        }

        public Dictionary<string, int> Run()
        {
            int next = 0;
            while (next < _instructions.Count)
            {
                next += _instructions[next].Execute();
            }

            return _memory;
        }

        private Dictionary<string, int> _memory = new Dictionary<string, int>();
        private List<Instruction> _instructions = new List<Instruction>();

        private void LoadInstruction(string instrucrion)
        {
            string[] tokens = instrucrion.Split(' ');
            if (tokens[0] == "mov")
            {
                _instructions.Add(new Move(tokens.Skip(1).ToList(), _memory));
            }
            else if (tokens[0] == "inc")
            {
                _instructions.Add(new Increment(tokens.Skip(1).ToList(), _memory));
            }
            else if (tokens[0] == "dec")
            {
                _instructions.Add(new Decrement(tokens.Skip(1).ToList(), _memory));
            }
            else if (tokens[0] == "jnz")
            {
                _instructions.Add(new JumpNotZero(tokens.Skip(1).ToList(), _memory));
            }
            else
            {
                throw new Exception($"Invalid command found: {tokens[0]}");
            }
        }
    }
}