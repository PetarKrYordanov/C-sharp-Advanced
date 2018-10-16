using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var basePath = @"../../../";
            string filePath = Path.Combine(basePath, "copyMe.png");            
            string copyPath = Path.Combine(basePath, "copyMeCopy.png");
            

            using (FileStream reader = new FileStream(filePath,FileMode.Open))
            {
                byte[] bytes = new byte[reader.Length];
                int numBytesToRead = (int)reader.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead.
                    int n = reader.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached.
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;

                // Write the byte array to the other FileStream.
                using (FileStream writer = new FileStream(copyPath,
                    FileMode.Create, FileAccess.Write))
                {
                    writer.Write(bytes, 0, numBytesToRead);
                }              
            }

        }
    }
}
