using System.Collections.Generic;
using Proxy.Service;

namespace Proxy.Proxy
{
    public class CachedYoutubeClass : IThirdPartyYoutubeLibrary
    {
        private IThirdPartyYoutubeLibrary _service;
        private List<string> _downloadedVideos;
        private List<string> _listCache;
        private string _videoCache;

        public CachedYoutubeClass(IThirdPartyYoutubeLibrary service)
        {
            _service = service;
        }

        public List<string> ListVideos()
        {
            return _listCache ?? (_listCache = _service.ListVideos());
        }

        public string GetVideoInfo(int id)
        {
            return _videoCache ?? (_videoCache = _service.GetVideoInfo(id));
        }
    }
}