using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CmdlinkFileTransfer;
using ProtoBuf;

namespace Deserialize.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var slnDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent;
            
            using(var fs = File.OpenRead(Path.Combine(slnDirectory.FullName,"protostream.bin")))
            {
                var deserialized = Serializer.Deserialize<GetDirectoryResponse>(fs);
                
            }
            Console.WriteLine("V1 -- Success");
        }
    }
}
