namespace API
{
    class DebugWriter : IOutputWriter
    {
        public void WriteOutput(string output)
        {
            System.Diagnostics.Debug.WriteLine(output);
        }
    }
}
