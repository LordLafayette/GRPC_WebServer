using Filesteam;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Google.Protobuf;
using Grpc.Core;

namespace FileSteamWebServer
{
    public class FileSteamImpl: FileSteamService.FileSteamServiceBase
    {
        public override async Task<fileBufferResponse> PushFileAsync(IAsyncStreamReader<fileBuffer> requestStream, ServerCallContext context)
        {
            try
            {
                Console.WriteLine("File income");
                FileStream fs = null;
                var size = 0;
                while (await requestStream.MoveNext())
                {
                    var cur = requestStream.Current;
                    if (fs == null)
                    {
                        var fileName = string.IsNullOrEmpty(cur.FileName) ? "newPushFile" : cur.FileName;
                        fs = File.Create(@"D:\fileReceive\"+fileName);
                    }

                    var buffer = cur.Buffer.ToByteArray();
                    size += buffer.Length;
                    if (buffer.Length < 1)
                        continue;

                    fs.Write(buffer, 0, buffer.Length);
                }

                Console.WriteLine("End receive " + (size / 1024));

                if (fs != null)
                {
                    fs.Dispose();
                }
            }
            catch(Exception e)
            {

            }
          

            return new fileBufferResponse();
        }
    }
}