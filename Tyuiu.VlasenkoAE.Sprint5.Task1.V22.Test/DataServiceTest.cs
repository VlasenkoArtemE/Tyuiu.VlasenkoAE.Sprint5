using System.IO;

using Tyuiu.VlasenkoAE.Sprint5.Task1.V22.Lib;

namespace Tyuiu.VlasenkoAE.Sprint5.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\artem\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
