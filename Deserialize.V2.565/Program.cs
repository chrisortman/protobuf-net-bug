using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CmdlinkFileTransfer;
using ProtoBuf;

namespace Deserialize.V2._565
{
    class Program
    {
        static void Main(string[] args)
        {
            var slnDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent;

            try
            {
                using(var fs = File.OpenRead(Path.Combine(slnDirectory.FullName, "protostream.bin")))
                {
                    var deserialized = Serializer.Deserialize<GetDirectoryResponse>(fs);

                }
                Console.WriteLine("V2.0.0.565 -- Success");
            }
            catch(Exception ex)
            {
                Console.WriteLine("V2.0.0.565 -- ERROR");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
