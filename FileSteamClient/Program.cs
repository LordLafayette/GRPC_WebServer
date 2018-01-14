using Filesteam;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSteamClient
{
    class Program
    {
        public class FileSteamClient
        {
            readonly FileSteamService.FileSteamServiceClient _client;
            
            public FileSteamClient(FileSteamService.FileSteamServiceClient client)
            {
                _client = client;
            }

            public async Task PushFileAsync()
            {
                try
                {
                    using(var call = _client.PushFile())
                    {
                        using(var fs = File.OpenRead("s.txt"))
                        {
                            Console.WriteLine("file size :" + (fs.Length / (float)1024) + " MB");
                            var bufferReaded = 0;
                            var buffer = new byte[255];
                            while((bufferReaded = fs.Read(buffer, 0, buffer.Length)) != 0){
                                Console.WriteLine("byte sent " + bufferReaded);
                                var byteString = ByteString.CopyFrom(bufferReaded<buffer.Length?buffer.Take(bufferReaded).ToArray():buffer);
                                var sendObj = new fileBuffer {
                                    Buffer = byteString,
                                    FileName = Path.GetFileName(fs.Name)
                            };

                                await call.RequestStream.WriteAsync(sendObj);
                            }
                            Console.WriteLine("send file finish");
                            await call.RequestStream.CompleteAsync();
                        }
                        var res = await call.ResponseAsync;
                    }
                }catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        } 

        static void Main(string[] args)
        {
            var channel = new Channel("127.0.0.1:52025", ChannelCredentials.Insecure);
            var client = new FileSteamClient(new FileSteamService.FileSteamServiceClient(channel));

            var task = client.PushFileAsync();
            Console.ReadLine();
            Console.WriteLine("enter");

            channel.ShutdownAsync().Wait();
            Console.ReadLine();
        }
    }
}
