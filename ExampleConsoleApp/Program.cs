
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoApiClient.Client;
using VideoApiClient.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new ApiVideoClient("APIKEY", VideoApiClient.Client.Environment.SANDBOX);

            var videoPayload = new VideoCreatePayload()
            {
                title = "Test chunk 2",
                description = "Video uploaded by c# client with chunks",
                mp4support = true,
                tags = new List<string>()
                {
                    "first","video","test","c#","client"
                }

            };

            var testCreate = api.Videos().create(videoPayload);
            api.SetUploadChunkSize(10000000);
            var file = File.OpenRead("C:\\Users\\pedro\\Videos\\testVideo2.mkv");
            //var testUpload = api.Videos().upload(testCreate.videoid, file);

            var test = api.Videos().list().execute().GetNextPage();

            Console.WriteLine("test");

            Console.ReadKey();
        }


    }
}
