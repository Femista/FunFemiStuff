using System.Collections.Generic;

namespace Proxy.Service
{
    public interface IThirdPartyYoutubeLibrary
    {
        List<string> ListVideos();
        string GetVideoInfo(int id);
    }
}