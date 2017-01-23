using System.Configuration;

namespace API
{
    public class Api
    {
        private IOutputWriter writer;

        public Api()
        {
            var outputTarget = ConfigurationManager.AppSettings["OutputTarget"];

            switch (outputTarget)
            {
                case "console":
                    writer = new ConsoleWriter();
                    break;
                case "database":
                    writer = new DatabaseWriter();
                    break;
                case "debug":
                    writer = new DebugWriter();
                    break;
                default:
                    break;
            }
        }

        public Api(IOutputWriter iOutputWriter)
        {
            writer = iOutputWriter;
        }

        public void WriteOutput(string output)
        {
            if (writer != null)
            {
                writer.WriteOutput(output);
            }
        }
    }
}
