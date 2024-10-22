using FileFound;

namespace FileFOund.Test
{
    [TestClass]
    public class FiileFoundTest
    {
        [TestMethod]
        public void FileLogFile_FileLength_True()
        {
            FileSearch fileSearch = new FileSearch();
            bool actual = fileSearch.FindLogFile(1000);
            Assert.IsTrue(actual);
        }
    }
}