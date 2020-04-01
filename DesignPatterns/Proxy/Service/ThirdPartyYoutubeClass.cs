using System;
using System.Collections.Generic;

namespace Proxy.Service
{
    public class ThirdPartyYoutubeClass : IThirdPartyYoutubeLibrary
    {
        private readonly List<string> _videoList = new List<string>
            {"Garfield 1", "Garfield 2: ELectric Boogaloo", "Garfield 3, The Revenge of the Mondays"};
        public List<string> ListVideos()
        {
            Console.WriteLine("Making api request to list videos");
            return _videoList;
        }

        public string GetVideoInfo(int id)
        {
            Console.WriteLine("Making api request to get videos");
            return _videoList[id];
        }
    }
}