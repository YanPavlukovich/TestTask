using System.Collections.Generic;

namespace ASMInterpreter
{
    public class SimpleAssembler
    {
        public static Dictionary<string, int> Interpret(string[] instructions)
        {
            Program program = new Program(instructions);
            return program.Run();
        }
    }
}