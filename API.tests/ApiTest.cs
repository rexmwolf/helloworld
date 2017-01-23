using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API.tests
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void TestOutput()
        {
            var testString = "__test_string__";

            // set up the api with a dummy output writer so we can capture the output
            var testOutputWriter = new TestOutputWriter();
            var api = new Api(testOutputWriter);

            // write the output
            api.WriteOutput(testString);

            // make sure our output writer received what we sent to the api
            Assert.AreEqual(testOutputWriter.Output, testString);
        }

        [TestMethod]
        public void TestNullOutputWriter()
        {
            var api = new Api();

            // make sure this doesn't blow up
            api.WriteOutput("__test_string__");
        }
    }

    class TestOutputWriter : IOutputWriter
    {
        public string Output = null;
        public void WriteOutput(string output)
        {
            Output = output;
        }
    }
}
