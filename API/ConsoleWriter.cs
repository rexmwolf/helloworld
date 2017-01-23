using System;

namespace API
{
    class ConsoleWriter : IOutputWriter
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}
