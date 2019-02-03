using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPGExample.Utility
{
    public static class IOHelper
    {
        public static Stream GetStreamFromFilePath(string filepath)
        {
            Stream s = null;
            s = File.OpenRead(filepath);
            return s;
        }

        public static void PutbyteDataInStream(Stream stream,ref byte[] data)
        {
            if(stream is MemoryStream)
            {
                MemoryStream m =(MemoryStream)stream;
                data = m.ToArray();
            }
            else
            {
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    data= memoryStream.ToArray();
                }
            }
        }

        public static string GetString(Stream inputStream)
        {
            string output;
            using (StreamReader reader = new StreamReader(inputStream))
            {
                output = reader.ReadToEnd();
            }
            return output;
        }

        public static void WriteStream(Stream inputStream, ref byte[] dataBytes)
        {
            using (Stream outputStream = inputStream)
            {
                outputStream.Write(dataBytes, 0, dataBytes.Length);
            }
        }
    }
}
