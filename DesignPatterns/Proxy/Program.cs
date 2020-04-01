using System;
using Proxy.Proxy;
using Proxy.Service;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var youtubeService = new ThirdPartyYoutubeClass();
            var youtubeProxy = new CachedYoutubeClass(youtubeService);
            foreach (var video in youtubeProxy.ListVideos())
            {
                Console.WriteLine(video);
            }
            foreach (var video in youtubeProxy.ListVideos())
            {
                Console.WriteLine(video);
            }
            Console.WriteLine(youtubeProxy.GetVideoInfo(1));
            Console.WriteLine(youtubeProxy.GetVideoInfo(1));
            Console.ReadLine();
        }
    }
}
