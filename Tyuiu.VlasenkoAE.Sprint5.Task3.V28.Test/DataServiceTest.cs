using System.IO;

using Tyuiu.VlasenkoAE.Sprint5.Task3.V28.Lib;

namespace Tyuiu.VlasenkoAE.Sprint5.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\artem\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
