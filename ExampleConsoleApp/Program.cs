
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using VideoApiClient.Client;
using VideoApiClient.Model;
using System.Diagnostics.Tracing;
using VideoApiClient.Upload;

namespace ConsoleApp1
{
    class UploadProgressListener : IUploadProgressListener
    {
        private DateTime lastUpload = DateTime.Now;
        public void onProgress(long bytesWritten, long totalBytes, int chunkCount, int chunkNum)
        {
            Console.WriteLine("Progress : " + bytesWritten + " / " + totalBytes + " - Chunk n°" + chunkNum + "/" + chunkCount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var api = new ApiVideoClient("r4qMAdUQBC7duPALUzEZtjKfQ0AlBqLfyCkgffLuNFH", VideoApiClient.Client.Environment.SANDBOX);

            var res = api.Videos().list().execute();
            var videoPayload = new VideoCreatePayload()
            {
                title = "Test chunk 3",
                description = "Video uploaded by c# client with chunks",
                mp4support = true,
                tags = new List<string>()
                {
                    "first","video","test","c#","client"
                }

            };

            var testCreate = api.Videos().create(videoPayload);
            api.SetTimeout(300000);
            api.SetUploadChunkSize(10000000);
            var file = File.OpenRead("C:\\Users\\pedro\\Videos\\testvideo.mp4");
            var upl = new UploadProgressListener();
            var testUpload = api.Videos().upload(testCreate.videoid, file, upl);

            //deleteAllVideos(api);
            var e = new EventListener();
            Console.WriteLine(testUpload);
            Console.ReadKey();
        }

        static void deleteAllVideos(ApiVideoClient api)
        {
            var firstPage = api.Videos().list().execute().Items;

            foreach(Video v in firstPage)
            {
                api.Videos().delete(v.videoid);
            }
        }
        static void readFile(Stream file)
        {
            byte[] TotalResult;

            var totalBytes = file.Length;
            var chunkSize = 10000000;

            using (var streamReader = new MemoryStream())
            {
                file.CopyTo(streamReader);
                TotalResult = streamReader.ToArray();
            }

            for(int i = 0;i < totalBytes;i+=chunkSize)
            {
                byte[] res = new byte[chunkSize];
                res = TotalResult.Skip(i).Take(chunkSize).ToArray();
                Console.WriteLine("bytes " + i + "-" + (Math.Min(i + chunkSize, totalBytes) - 1) + "/" + totalBytes);

            }


        }


    }
}
