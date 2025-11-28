using System.IO;

using Tyuiu.VlasenkoAE.Sprint5.Task7.V28.Lib;

namespace Tyuiu.VlasenkoAE.Sprint5.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\artem\AppData\Local\Temp\OutPutFileTask7V28.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
